using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleParking
{
    public partial class Form1 : Form
    {
        BicycleParking bp;
        public Form1()
        {
            InitializeComponent();
            bp = new BicycleParking(1.50, 0.50);
        }

        private void btnParkBicycle_Click(object sender, EventArgs e)
        {
            if(rbnNormal.Checked)
            {
                lblTicketNumber.Text = bp.ParkBicycle(BicycleType.NORMAL);

            }
            else if(rbnElectric.Checked)
            {
                lblTicketNumber.Text = bp.ParkBicycle(BicycleType.ELECTRIC);
            }
            else if (rbnTandem.Checked)
            {
                lblTicketNumber.Text = bp.ParkBicycle(BicycleType.TANDEM);
            }
            else if (rbnFolding.Checked)
            {
                lblTicketNumber.Text = bp.ParkBicycle(BicycleType.FOLDING);
            }
            UpdateTicketNrCB();
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            if(cbbTicketnumbers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select ticket number.");
            }
            else
            {
                RetrieveForm f = new RetrieveForm(this.bp, cbbTicketnumbers.SelectedItem.ToString());
                f.ShowDialog();
            }
            
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbxPartialZipcode.Text))
            {
                MessageBox.Show("Please fill in partial zipcode.");
            }
            else
            {
                StatisticsForm sf = new StatisticsForm(this.bp, tbxPartialZipcode.Text);
                sf.ShowDialog();
            }
            
        }
        private void UpdateTicketNrCB()
        {
            cbbTicketnumbers.Items.Clear();
            foreach(string s in bp.GetAllBNr())
            {
                cbbTicketnumbers.Items.Add(s);
            }
        }
    }
}
