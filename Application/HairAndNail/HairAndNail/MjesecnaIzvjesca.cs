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
    public partial class MjesecnaIzvjesca : Form
    {
        private Korisnik _korisnik;
        List<Salon> saloni;
        public MjesecnaIzvjesca()
        {
            InitializeComponent();
            _korisnik=PrivremeniLogin.Korisnik;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
           
            List<Racun> racuni = new List<Racun>();
            using (var db=new Entities())
            {
                saloni = db.Korisnik.FirstOrDefault(_ => _.Id == _korisnik.Id).Salon.ToList();
                saloni.ForEach(salon =>
                {
                    racuni.AddRange(db.Racun.Where(_ => _.Salon_id==salon.Id && dateTimePicker1.Value<_.Datum && dateTimePicker2.Value>_.Datum).ToList());
                });            
            }
            RacunBindingSource.DataSource = racuni;
            this.reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
        }
        

        private void MjesecnaIzvjesca_Load(object sender, EventArgs e)
        {

            this.reportViewer1.Visible = false;
        }

        private void reportViewer1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
           
        }

        private void MjesecnaIzvjesca_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }
    }
}
