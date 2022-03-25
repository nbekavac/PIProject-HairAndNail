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
    public partial class UpravljanjeUlogama : Form
    {
        PopupNotifier popup = new PopupNotifier();
        public UpravljanjeUlogama()
        {
            InitializeComponent();
            OsvjeziTipoveKorisnika();
            OsvjeziUloge();
        }

        private void OsvjeziTipoveKorisnika()
        {
            List<Tip_korisnika> tipoviKorisnika = new List<Tip_korisnika>();
            using (Entities db = new Entities())
            {
                tipoviKorisnika = db.Tip_korisnika.ToList();
                dgvTipKorisnika.DataSource = tipoviKorisnika;
                dgvTipKorisnika.Columns[3].Visible = false;
                dgvTipKorisnika.Columns[4].Visible = false;

            }         
        }
        private void OsvjeziUloge()
        {
            List<Uloga> uloge = new List<Uloga>();
            using (Entities db = new Entities())
            {
                uloge = db.Uloga.ToList();
                cmbUloge.DataSource = uloge;
                cmbUloge.ValueMember = "Id";
                cmbUloge.DisplayMember = "Naziv";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {              
                    Tip_korisnika tipKorisnika = new Tip_korisnika
                    {
                        Naziv=txtNaziv.Text,
                        Opis=txtOpis.Text
                    };

                    db.Tip_korisnika.Add(tipKorisnika);
                    db.SaveChanges();                     
            }
            OsvjeziTipoveKorisnika();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Tip_korisnika tip_Korisnika = dgvTipKorisnika.CurrentRow.DataBoundItem as Tip_korisnika;

            using (Entities db = new Entities())
            {
                db.Tip_korisnika.Attach(tip_Korisnika);
                if (txtNaziv.Text!="" && txtOpis.Text!="")
                {
                    tip_Korisnika.Naziv = txtNaziv.Text;
                    tip_Korisnika.Opis = txtOpis.Text;
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Niste unijeli naziv i/ili opis", "Upozorenje", MessageBoxButtons.OK);
                }
            }
            OsvjeziTipoveKorisnika();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                Tip_korisnika tip_Korisnika = dgvTipKorisnika.CurrentRow.DataBoundItem as Tip_korisnika;
                db.Tip_korisnika.Attach(tip_Korisnika);
                if (tip_Korisnika != null)
                {
                    db.Tip_korisnika.Remove(tip_Korisnika);
                    db.SaveChanges();
                }
            }
            OsvjeziTipoveKorisnika();
        }

        private void btnDodajUloguTipu_Click(object sender, EventArgs e)
        {
            Tip_korisnika tip_Korisnika = dgvTipKorisnika.CurrentRow.DataBoundItem as Tip_korisnika;
            int idUloge = int.Parse(cmbUloge.SelectedValue.ToString());

            using (Entities db = new Entities())
            {
                db.Tip_korisnika.Attach(tip_Korisnika);
                Tip_korisnika provjera =db.Uloga.FirstOrDefault(_ => _.Id == idUloge).Tip_korisnika.FirstOrDefault(_ => _.Id == tip_Korisnika.Id);
                if (provjera == null)
                {
                    db.Uloga.FirstOrDefault(_ => _.Id == idUloge).Tip_korisnika.Add(tip_Korisnika);
                    db.SaveChanges();
                    popup.TitleText = "Obavijest";
                    popup.ContentText = "Uloga je dodana tom tipu korisnika!";
                    popup.Popup();
                }
                else
                {
                    popup.TitleText = "Upozorenje";
                    popup.ContentText = "Taj tip korisnika već ima tu ulogu";
                    popup.Popup();
                }
            }
        }

        private void btnObrisiUloguTipu_Click(object sender, EventArgs e)
        {
            Tip_korisnika tip_Korisnika = dgvTipKorisnika.CurrentRow.DataBoundItem as Tip_korisnika;
            int idUloge = int.Parse(cmbUloge.SelectedValue.ToString());

            using (Entities db = new Entities())
            {

                db.Tip_korisnika.Attach(tip_Korisnika);
                Tip_korisnika provjera = db.Uloga.FirstOrDefault(_ => _.Id == idUloge).Tip_korisnika.FirstOrDefault(_ => _.Id == tip_Korisnika.Id);
                if (provjera != null)
                {
                    db.Uloga.FirstOrDefault(_ => _.Id == idUloge).Tip_korisnika.Remove(tip_Korisnika);
                    db.SaveChanges();
                    popup.TitleText = "Obavijest";
                    popup.ContentText = "Uloga je obrisana tom tipu";
                    popup.Popup();
                }
                else
                {
                    popup.TitleText = "Upozorenje";
                    popup.ContentText = "Taj tip nema tu ulogu, pa ju nije ni moguće brisati";
                    popup.Popup();
                }
            }
        }

        private void UpravljanjeUlogama_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
        }
    }
}
