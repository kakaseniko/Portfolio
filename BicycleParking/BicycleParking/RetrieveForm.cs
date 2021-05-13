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
    public partial class RetrieveForm : Form
    {
        private string ticketNumber;
        BicycleParking bp;
        public RetrieveForm(BicycleParking bp, string ticketNumber)
        {
            InitializeComponent();
            this.ticketNumber = ticketNumber;
            this.bp = bp;
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            int hours;
            if(String.IsNullOrWhiteSpace(tbxHoursInParking.Text))
            {
                MessageBox.Show("Please fill in hours in parking.");
            }
            else if(!Int32.TryParse(tbxHoursInParking.Text, out hours))
            {
                MessageBox.Show("Please enter numeric value to hours in parking");
            }
            else
            {
                double price = bp.RetrieveBicycle(ticketNumber, hours, tbxOwnerZipcode.Text);
                if ( price == -1)
                {
                             
                    MessageBox.Show("No parked bicycle was found with selected ticket number.");
                    this.Close();
                    return;
                }
                MessageBox.Show($"The total cost is: €{price}");
                this.Close();
            }
            
        }
    }
}
