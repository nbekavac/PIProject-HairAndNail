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
    public partial class DodajSmjenu : Form
    {
        private Smjena _smjena;
        public DodajSmjenu(Smjena smjena)
        {
            InitializeComponent();
            _smjena = smjena;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string pocetakSmjene = txtPocetakSmjeneSati.Text + ":" + txtPocetakSmjeneMinute.Text;
            string krajSmjene = txtKrajSmjeneSati.Text + ":" + txtKrajSmjeneMinute.Text;
            if (txtPocetakSmjeneSati.Text == "" || txtKrajSmjeneSati.Text == "" || txtPocetakSmjeneMinute.Text == "" || txtKrajSmjeneMinute.Text == "")
            {
                MessageBox.Show("Niste unijeli ispravno podatke", "Upozorenje", MessageBoxButtons.OK);
            }
            else
            {
                using (Entities db = new Entities())
                {
                    if (_smjena == null)
                    {
                        Smjena smjena = new Smjena()
                        {
                            Datum = dateTimePicker1.Value,
                            Pocetak_smjene = TimeSpan.Parse(pocetakSmjene),
                            Kraj_smjene = TimeSpan.Parse(krajSmjene)
                        };
                        db.Smjena.Add(smjena);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Smjena.Attach(_smjena);
                        _smjena.Datum = dateTimePicker1.Value;
                        _smjena.Pocetak_smjene = TimeSpan.Parse(pocetakSmjene);
                        _smjena.Kraj_smjene = TimeSpan.Parse(krajSmjene);
                        db.SaveChanges();
                    }
                    this.Close();
                }
            }
            
        }

        private void DodajSmjenu_Load(object sender, EventArgs e)
        {
            if (_smjena!=null)
            {
                string[] pocetakSmjene=_smjena.Pocetak_smjene.ToString().Split(':');
                string[] krajSmjene = _smjena.Kraj_smjene.ToString().Split(':');
                txtPocetakSmjeneSati.Text = pocetakSmjene[0];
                txtPocetakSmjeneMinute.Text = pocetakSmjene[1];
                txtKrajSmjeneSati.Text = krajSmjene[0];
                txtKrajSmjeneMinute.Text = krajSmjene[1];                
                _smjena.Datum = dateTimePicker1.Value;             
            }
        }

        private void DodajSmjenu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
