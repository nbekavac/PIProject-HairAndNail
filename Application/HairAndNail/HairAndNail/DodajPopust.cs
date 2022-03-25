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
    public partial class DodajPopust : Form
    {
        private Popust _popust;
        Korisnik _korisnik = PrivremeniLogin.Korisnik;  
        

        public DodajPopust(Popust popust)
        {
            InitializeComponent();
            _popust = popust;
        }
        
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text=="" || txtOpis.Text=="" || txtKod.Text=="")
            {
                MessageBox.Show("Niste unijeli ispravno podatke", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                using (Entities db = new Entities())
                {
                    var salonId = db.Korisnik.FirstOrDefault(_ => _.Id == _korisnik.Id).Salon.Select(_ => _.Id);
                    int salonId1 = 0;
                    foreach (var item in salonId)
                    {
                        salonId1 = int.Parse(item.ToString());
                        break;
                    }
                    var tvrtkaId = db.Salon.FirstOrDefault(_ => _.Id == salonId1).Tvrtka.Id;
                    if (_popust == null)
                    {
                        Popust popust = new Popust
                        {
                            Naziv = txtNaziv.Text,
                            Opis = txtOpis.Text,
                            Datum_pocetka = dateTimePicker1.Value,
                            Datum_kraja = dateTimePicker2.Value,
                            Kod = txtKod.Text,
                            TvrtkaId = tvrtkaId
                        };
                        db.Popust.Add(popust);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Popust.Attach(_popust);
                        _popust.Naziv = txtNaziv.Text;
                        _popust.Opis = txtOpis.Text;
                        _popust.Datum_pocetka = dateTimePicker1.Value;
                        _popust.Datum_kraja = dateTimePicker2.Value;
                        _popust.Kod = txtKod.Text;
                        _popust.TvrtkaId = tvrtkaId;
                        db.SaveChanges();
                    }
                    this.Close();
                }
            }
           
        }

        private void DodajPopust_Load(object sender, EventArgs e)
        {
            if (_popust != null)
            {
                txtNaziv.Text = _popust.Naziv;
                txtOpis.Text = _popust.Opis;
                dateTimePicker1.Value = _popust.Datum_pocetka.Value;
                dateTimePicker2.Value = _popust.Datum_kraja.Value;
                txtKod.Text = _popust.Kod;
               
            }
        }

        private void DodajPopust_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
