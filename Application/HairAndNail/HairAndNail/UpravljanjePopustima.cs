using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HairAndNailData.Model;
using HairAndNailData;

namespace HairAndNail
{
    public partial class UpravljanjePopustima : Form
    {
        private Korisnik _korisnik;
        public UpravljanjePopustima()
        {
            InitializeComponent();
            _korisnik = PrivremeniLogin.Korisnik;
            OsvjeziSvePopuste();
           
        }
        
        private void OsvjeziSvePopuste()
        {
            using (Entities db = new Entities())
            {
                var saloni = db.Korisnik.FirstOrDefault(_ => _.Id == _korisnik.Id).Salon;
                int salonId=0;
                foreach (var salon in saloni)
                {
                    salonId = db.Salon.FirstOrDefault(_ => _.Id == salon.Id).Id;
                    break;
                }
                int tvrtkaId = int.Parse(db.Salon.FirstOrDefault(_ => _.Id == salonId).TvrtkaId.ToString());
                var popust = db.Popust.Where(_=>_.TvrtkaId==tvrtkaId).ToList();
                dgvPopust.DataSource = popust;
                dgvPopust.Columns[6].Visible = false;
                dgvPopust.Columns[7].Visible = false;
                dgvPopust.Columns[8].Visible = false;
            }
        }

        private void dgvPopust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajPopust dodajPopust = new DodajPopust(null);
            dodajPopust.ShowDialog();
            OsvjeziSvePopuste();
        }

        private void btnAzurirajPopust_Click(object sender, EventArgs e)
        {
            DodajPopust dodajPopust = new DodajPopust(dgvPopust.CurrentRow.DataBoundItem as Popust);
            dodajPopust.ShowDialog();
            OsvjeziSvePopuste();
        }

        private void btnObrisiPopust_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                db.Popust.Attach(dgvPopust.CurrentRow.DataBoundItem as Popust);
                db.Popust.Remove(dgvPopust.CurrentRow.DataBoundItem as Popust);
                db.SaveChanges();
            }
            OsvjeziSvePopuste();
        }

        private void UpravljanjePopustima_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
