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


namespace HairAndNail
{
    public partial class PrivremeniLogin : Form
    {
        public static Korisnik Korisnik;
        public PrivremeniLogin()
        {
            InitializeComponent();
            DohvatiKorisnika();
        }
        private void DohvatiKorisnika()
        {
            using (Entities db = new Entities())
            {
                var korisnickoIme = db.Korisnik.ToList();
                cmbKorisnickoIme.DataSource = korisnickoIme;
                cmbKorisnickoIme.DisplayMember = "Korisnicko_ime";
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Korisnik = cmbKorisnickoIme.SelectedValue as Korisnik;
            PrivremenaForma privremenaForma = new PrivremenaForma(Korisnik);
            privremenaForma.ShowDialog();
        }

        private void PrivremeniLogin_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
