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
    public partial class PregledPopusta : Form
    {
        public PregledPopusta()
        {
            InitializeComponent();
            
          


        }
        private void OsvjeziPopuste()
        {
            int salonId, tvrtkaId;
            dgvPopust.DataSource = null;
            salonId = int.Parse(cmbSalon.SelectedValue.ToString());
            using (Entities db = new Entities())
            {          
                tvrtkaId = db.Salon.FirstOrDefault(_ => _.Id == salonId).TvrtkaId.Value;
                var salon = db.Salon.FirstOrDefault(_ => _.Id == salonId);
                var popusti = db.Popust.Where(_ => _.Datum_pocetka < DateTime.Now && _.Datum_kraja > DateTime.Now && _.TvrtkaId==tvrtkaId).ToList();
                dgvPopust.DataSource = popusti;
                dgvPopust.Columns[6].Visible = false;
                dgvPopust.Columns[7].Visible = false;
                dgvPopust.Columns[8].Visible = false;
            }            
        }
        private void OsvjeziSalone()
        {
            List<Salon> saloni;
            cmbSalon.DataSource = null;
            using (Entities db=new Entities())
            {
                saloni = db.Salon.ToList();
                cmbSalon.DataSource = saloni;
                cmbSalon.DisplayMember = "Naziv";
                cmbSalon.ValueMember = "Id";
            }
        }

        private void PregledPopusta_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.ShowDialog();
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbSalon_SelectedValueChanged(object sender, EventArgs e)
        {                   
        }

        private void cmbSalon_MouseLeave(object sender, EventArgs e)
        {
            OsvjeziPopuste();
        }

        private void cmbSalon_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void PregledPopusta_Load(object sender, EventArgs e)
        {
            OsvjeziSalone();
            OsvjeziPopuste();
        }
    }
}
