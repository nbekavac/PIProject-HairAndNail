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

namespace HairAndNail
{
    public partial class UpravljanjeZaposlenicima : Form
    {
        private Korisnik _korisnik;
        List<Salon> _salon;

        public UpravljanjeZaposlenicima()
        {
            InitializeComponent();
            _korisnik = PrivremeniLogin.Korisnik;
        }

        private void UpravljanjeZaposlenicima_Load(object sender, EventArgs e)
        {
            OsvjeziKorisnike();
        }
        private void OsvjeziKorisnike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            using (Entities db = new Entities())
            {
                _salon = db.Korisnik.FirstOrDefault(_ => _.Id == _korisnik.Id).Salon.ToList();

                _salon.ForEach(salon =>
                {
                    korisnici.AddRange(db.Korisnik.Where(_ => _.Salon.Any(s => s.Id == salon.Id) && _.Tip_korisnika != 1).ToList());
                });                
            }
            dgvKorisnici.DataSource = korisnici;
            dgvKorisnici.Columns[7].Visible = false;
            dgvKorisnici.Columns[8].Visible = false;
            dgvKorisnici.Columns[9].Visible = false;
            dgvKorisnici.Columns[10].Visible = false;
            dgvKorisnici.Columns[11].Visible = false;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodajZaposlenika = new DodajZaposlenika(null, _salon);
            dodajZaposlenika.ShowDialog();
            OsvjeziKorisnike();
        }
      
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                Korisnik selektiraniKorisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                db.Korisnik.Attach(selektiraniKorisnik);
                if (selektiraniKorisnik != null)
                {
                    db.Korisnik.Remove(selektiraniKorisnik);
                    db.SaveChanges();
                }
            }
            OsvjeziKorisnike();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Korisnik selektiraniKorisnik = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
            DodajZaposlenika dodajZaposlenika = new DodajZaposlenika(selektiraniKorisnik, _salon);
            dodajZaposlenika.ShowDialog();
            OsvjeziKorisnike();
        }

        private void UpravljanjeZaposlenicima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
