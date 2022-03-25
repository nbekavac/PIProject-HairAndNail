using HairAndNailData.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairAndNail
{
    public partial class PrivremenaForma : Form
    {
        private Korisnik _korisnik;



        public PrivremenaForma(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;


            using (Entities db = new Entities())
            {
                var korisnikoveUloge = db.Tip_korisnika.FirstOrDefault(_ => _.Id == _korisnik.Tip_korisnika).Uloga.Select(_ => _.Naziv).ToList();
                upravljanjeZaposlenicimaToolStripMenuItem.Visible = false;
                upravljanjeSmjenamaToolStripMenuItem.Visible = false;
                pregledPopustaToolStripMenuItem.Visible = false;
                mjesećnaIzvješćaToolStripMenuItem.Visible = false;
                upravljanjeUlogamaToolStripMenuItem.Visible = false;
                dodajPopustToolStripMenuItem.Visible = false;
                zaposleniciToolStripMenuItem.Visible = false;
                smjenaToolStripMenuItem.Visible = false;
                popustiToolStripMenuItem.Visible = false;
                računiToolStripMenuItem.Visible = false;

                foreach (var korisnikovaUloga in korisnikoveUloge)
                {
                    if (korisnikovaUloga == "Upravljanje Korisnicima")
                    {
                        zaposleniciToolStripMenuItem.Visible = true;
                        upravljanjeZaposlenicimaToolStripMenuItem.Visible = true;

                    }
                    if (korisnikovaUloga == "Evidencija Korisnika")
                    {
                        smjenaToolStripMenuItem.Visible = true;
                        upravljanjeSmjenamaToolStripMenuItem.Visible = true;
                    }
                    if (korisnikovaUloga == "Pregled Popusta")
                    {
                        popustiToolStripMenuItem.Visible = true;
                        pregledPopustaToolStripMenuItem.Visible = true;
                    }
                    if (korisnikovaUloga == "Mjesećna Izvješća")
                    {
                        računiToolStripMenuItem.Visible = true;
                        mjesećnaIzvješćaToolStripMenuItem.Visible = true;
                    }
                    if (korisnikovaUloga == "Upravljanje ulogama")
                    {
                        zaposleniciToolStripMenuItem.Visible = true;
                        upravljanjeUlogamaToolStripMenuItem.Visible = true;
                    }
                    if (korisnikovaUloga == "Upravljanje popustima")
                    {
                        popustiToolStripMenuItem.Visible = true;
                        dodajPopustToolStripMenuItem.Visible = true;
                    }

                }

            }
        }



        private void btnUpravljanjeZaposlenicima_Click(object sender, EventArgs e)
        {
        }

        private void btnEvidencijaZaposlenika_Click(object sender, EventArgs e)
        {
        }

        UpravljanjeZaposlenicima upravljanjeZaposlenicima;

        private void upravljanjeZaposlenicimaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (upravljanjeZaposlenicima == null)
            {
                upravljanjeZaposlenicima = new UpravljanjeZaposlenicima();
                upravljanjeZaposlenicima.MdiParent = this;
                upravljanjeZaposlenicima.FormClosed += UpravljanjeZaposlenicima_FormClosed;
                upravljanjeZaposlenicima.Show();
            }
            else
            {
                upravljanjeZaposlenicima.Activate();
            }
        }

        private void UpravljanjeZaposlenicima_FormClosed(object sender, FormClosedEventArgs e)
        {
            upravljanjeZaposlenicima = null;
        }

        EvidencijaZaposlenika evidencijaZaposlenika;
        private void upravljanjeSmjenamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (evidencijaZaposlenika == null)
            {
                evidencijaZaposlenika = new EvidencijaZaposlenika();
                evidencijaZaposlenika.MdiParent = this;
                evidencijaZaposlenika.FormClosed += EvidencijaZaposlenika_FormClosed;
                evidencijaZaposlenika.Show();
            }
            else
            {
                evidencijaZaposlenika.Activate();
            }
        }

        private void EvidencijaZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            evidencijaZaposlenika = null;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horizontalniPogledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vertikalniPogledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void rasporediIkoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        PregledPopusta pregledPopusta;
        private void pregledPopustaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pregledPopusta == null)
            {
                pregledPopusta = new PregledPopusta();
                pregledPopusta.MdiParent = this;
                pregledPopusta.FormClosed += PregledPopusta_FormClosed;
                pregledPopusta.Show();
            }
            else
            {
                pregledPopusta.Activate();
            }
        }

        private void PregledPopusta_FormClosed(object sender, FormClosedEventArgs e)
        {
            pregledPopusta = null;
        }
        UpravljanjePopustima upravljanjePopustima;
        private void dodajPopustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upravljanjePopustima == null)
            {
                upravljanjePopustima = new UpravljanjePopustima();
                upravljanjePopustima.MdiParent = this;
                upravljanjePopustima.FormClosed += UpravljanjePopustima_FormClosed;
                upravljanjePopustima.Show();
            }
            else
            {
                upravljanjePopustima.Activate();
            }
        }

        private void UpravljanjePopustima_FormClosed(object sender, FormClosedEventArgs e)
        {
            upravljanjePopustima = null;
        }
        UpravljanjeUlogama upravljanjeUlogama;
        private void upravljanjeUlogamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (upravljanjeUlogama == null)
            {
                upravljanjeUlogama = new UpravljanjeUlogama();
                upravljanjeUlogama.MdiParent = this;
                upravljanjeUlogama.FormClosed += UpravljanjeUlogama_FormClosed;
                upravljanjeUlogama.Show();
            }
            else
            {
                upravljanjeUlogama.Activate();
            }
        }

        private void UpravljanjeUlogama_FormClosed(object sender, FormClosedEventArgs e)
        {
            upravljanjeUlogama = null;
        }

        private void PrivremenaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();


            /*private void mjesecnaIzvjescaToolStripMenuItem_Click(object sender, EventArgs e)
            {*/
        }

        MjesecnaIzvjesca mjesecnaIzvjesca;
        private void mjesećnaIzvješćaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mjesecnaIzvjesca == null)
            {
                mjesecnaIzvjesca = new MjesecnaIzvjesca();
                mjesecnaIzvjesca.MdiParent = this;
                mjesecnaIzvjesca.FormClosed += MjesecnaIzvjesca_FormClosed;
                mjesecnaIzvjesca.Show();
            }
            else
            {
                mjesecnaIzvjesca.Activate();
            }
        }

        private void MjesecnaIzvjesca_FormClosed(object sender, FormClosedEventArgs e)
        {
            mjesecnaIzvjesca = null;
        }
    }
}