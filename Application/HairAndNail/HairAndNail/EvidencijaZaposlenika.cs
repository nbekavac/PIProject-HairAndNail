using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HairAndNailData;
using HairAndNailData.Model;
using Tulpep.NotificationWindow;

namespace HairAndNail
{
    public partial class EvidencijaZaposlenika : Form
    {
        private Korisnik _korisnik;
        List<Salon> _salon;
        PopupNotifier popup = new PopupNotifier();

        public EvidencijaZaposlenika()
        {
            InitializeComponent();
        }

        private void EvidencijaZaposlenika_Load(object sender, EventArgs e)
        {
            _korisnik = PrivremeniLogin.Korisnik;
            OsvjeziSmjene();
            OsvjeziZaposlenike();

         
        }

        private void btnDodajSmjenu_Click(object sender, EventArgs e)
        {
            DodajSmjenu dodajSmjenu = new DodajSmjenu(null);
            dodajSmjenu.ShowDialog();
            OsvjeziSmjene();
        }

        private void btnAzurirajSmjenu_Click(object sender, EventArgs e)
        {
            DodajSmjenu dodajSmjenu = new DodajSmjenu(dgvSmjene.CurrentRow.DataBoundItem as Smjena);
            dodajSmjenu.ShowDialog();
            OsvjeziSmjene();
        }

        private void btnObrisiSmjenu_Click(object sender, EventArgs e)
        {
            Smjena smjenaZaBrisati = dgvSmjene.CurrentRow.DataBoundItem as Smjena;
            using (Entities db = new Entities())
            {
                db.Smjena.Attach(smjenaZaBrisati);
                db.Smjena.Remove(smjenaZaBrisati);
                db.SaveChanges();

            }
            OsvjeziSmjene();
        }
        private void OsvjeziSmjene()
        {
            List<Smjena> smjene = new List<Smjena>();
            using (Entities db = new Entities())
            {
                smjene = db.Smjena.ToList();
            }
            dgvSmjene.DataSource = smjene;
            dgvSmjene.Columns[4].Visible = false;
        }
        private void OsvjeziZaposlenike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            using (Entities db = new Entities())
            {
                _salon = db.Korisnik.FirstOrDefault(_ => _.Id == _korisnik.Id).Salon.ToList();

                _salon.ForEach(salon =>
                {
                    korisnici.AddRange(db.Korisnik.Where(_ => _.Salon.Any(s => s.Id == salon.Id) && _.Tip_korisnika != 1).ToList());
                });
                var zaposlenici = korisnici.Select(_ => new { Id = _.Id, PunoIme = _.Ime + " " + _.Prezime }).ToList();
                cmbZaposlenik.ValueMember = "Id";
                cmbZaposlenik.DisplayMember = "PunoIme";
                cmbZaposlenik.DataSource = zaposlenici;
            }
        }
        private void OsvjeziZaposlenikoveSmjene()
        {
            int korisnikId = int.Parse(cmbZaposlenik.SelectedValue.ToString());
            dgvTrenutneSmjene.DataSource = null;

            using (Entities db = new Entities())
            {
                var smjena = db.Korisnik.FirstOrDefault(_ => _.Id == korisnikId).Smjena.ToList();
                dgvTrenutneSmjene.DataSource = smjena;
                dgvTrenutneSmjene.Columns[4].Visible = false;
            }
           
        }

        

        private void btnDodajZaposlenikaUSmjenu_Click(object sender, EventArgs e)
        {
            int korisnikId = int.Parse(cmbZaposlenik.SelectedValue.ToString());
            Smjena smjena = dgvSmjene.CurrentRow.DataBoundItem as Smjena;


            if (smjena==null)
            {
                popup.TitleText = "Upozorenje";
                popup.ContentText = "Niste odabrali korisnika i/ili smjenu";
                popup.Popup();
               
            }
            else
            {
                using (Entities db = new Entities())
                {
                    Korisnik korisnikZaSpremiti = db.Korisnik.FirstOrDefault(_ => _.Id == korisnikId);
                    Smjena smjenaZaSpremiti = db.Smjena.FirstOrDefault(_ => _.Id == smjena.Id);

                    var provjera=db.Smjena.FirstOrDefault(_ => _.Id == smjenaZaSpremiti.Id).Korisnik.FirstOrDefault(_ => _.Id == korisnikZaSpremiti.Id);

                    if (provjera == null)
                    {
                        db.Smjena.FirstOrDefault(_ => _.Id == smjenaZaSpremiti.Id).Korisnik.Add(korisnikZaSpremiti);
                        db.SaveChanges();                     
                    }
                    else
                    {
                        popup.TitleText = "Upozorenje";
                        popup.ContentText = "Zaposlenik u toj smjeni već postoji";
                        popup.Popup();
                    }
                }
               
            }
            OsvjeziZaposlenikoveSmjene();
            
        }

        private void cmbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziZaposlenikoveSmjene();
        }

        private void btnAzurirajZaposlenikaUSmjenu_Click(object sender, EventArgs e)
        {
            Smjena sveSmjene = dgvSmjene.CurrentRow.DataBoundItem as Smjena;
            int korisnikId = int.Parse(cmbZaposlenik.SelectedValue.ToString());
            Smjena smjenaZaAzurirat = dgvTrenutneSmjene.CurrentRow.DataBoundItem as Smjena;

            using (Entities db = new Entities())
            {         
                db.Smjena.Attach(smjenaZaAzurirat);
                db.Korisnik.FirstOrDefault(_ => _.Id == korisnikId).Smjena.Remove(smjenaZaAzurirat);
                db.SaveChanges();

                var smjena = db.Smjena.FirstOrDefault(_ => _.Id == sveSmjene.Id);
                db.Korisnik.FirstOrDefault(_ => _.Id == korisnikId).Smjena.Add(smjena);
                db.SaveChanges();
            }
            OsvjeziZaposlenikoveSmjene();
        }

        private void btnObrisiZaposlenikaIzSmjene_Click(object sender, EventArgs e)
        {
            Smjena smjenaZaObrisati = dgvTrenutneSmjene.CurrentRow.DataBoundItem as Smjena;
            int korisnikId = int.Parse(cmbZaposlenik.SelectedValue.ToString());
            using (Entities db = new Entities())
            {
                db.Smjena.Attach(smjenaZaObrisati);
                db.Korisnik.FirstOrDefault(_ => _.Id == korisnikId).Smjena.Remove(smjenaZaObrisati);
                db.SaveChanges();
            }
            OsvjeziZaposlenikoveSmjene();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EvidencijaZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
