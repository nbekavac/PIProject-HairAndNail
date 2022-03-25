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
    public partial class DodajZaposlenika : Form
    {
        private Korisnik _korisnik;
        private List<Salon> _salon;
        int idSalon;

        public DodajZaposlenika(Korisnik korisnik,List<Salon> salon)
        {
            InitializeComponent();
            _korisnik = korisnik;
            _salon = salon;
           
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            idSalon = int.Parse(cmbSalon.SelectedValue.ToString());
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtLozinka.Text == "" || txtKorisnickoIme.Text == "" || txtEmail.Text=="")
            {
                MessageBox.Show("Niste unijeli ispravno podatke", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                using (Entities db = new Entities())
                {
                    if (_korisnik == null)
                    {

                        Korisnik korisnik = new Korisnik
                        {
                            Ime = txtIme.Text,
                            Prezime = txtPrezime.Text,
                            Korisnicko_ime = txtKorisnickoIme.Text,
                            Lozinka = txtLozinka.Text,
                            Email = txtEmail.Text,
                            Tip_korisnika = int.Parse(cmbTipKorisnika.SelectedValue.ToString())
                        };

                        db.Korisnik.Add(korisnik);
                        db.SaveChanges();

                        db.Salon.FirstOrDefault(_ => _.Id == idSalon).Korisnik.Add(korisnik);
                        db.SaveChanges();

                    }
                    else
                    {
                        db.Korisnik.Attach(_korisnik);
                        _korisnik.Ime = txtIme.Text;
                        _korisnik.Prezime = txtPrezime.Text;
                        _korisnik.Korisnicko_ime = txtKorisnickoIme.Text;
                        _korisnik.Lozinka = txtLozinka.Text;
                        _korisnik.Email = txtEmail.Text;
                        _korisnik.Tip_korisnika = int.Parse(cmbTipKorisnika.SelectedValue.ToString());
                        db.SaveChanges();

                        int id = _korisnik.Salon.FirstOrDefault().Id;

                        db.Salon.FirstOrDefault(_ => _.Id == id).Korisnik.Remove(_korisnik);
                        db.SaveChanges();

                        db.Salon.FirstOrDefault(_ => _.Id == idSalon).Korisnik.Add(_korisnik);
                        db.SaveChanges();
                    }
                }
                this.Close();
            }
            
        }

        private void DodajZaposlenika_Load(object sender, EventArgs e)
        {

            using (Entities db = new Entities())
            {
                var tip_Korisnika = db.Tip_korisnika.Select(_ => new { Id = _.Id, Naziv = _.Naziv }).ToList();
                cmbTipKorisnika.ValueMember = "Id";
                cmbTipKorisnika.DisplayMember = "Naziv";
                cmbTipKorisnika.DataSource = tip_Korisnika;

                cmbSalon.DataSource = _salon;
                cmbSalon.ValueMember = "Id";
                cmbSalon.DisplayMember = "Naziv";
            }

            if (_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtKorisnickoIme.Text = _korisnik.Korisnicko_ime;
                txtLozinka.Text = _korisnik.Lozinka;
                txtEmail.Text = _korisnik.Email;
                cmbTipKorisnika.SelectedValue = _korisnik.Tip_korisnika;
                
            }
           
        }

        private void DodajZaposlenika_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
