using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModulesAndInterfaces;
using ModulesAndInterfaces.CustomExceptions;

namespace MediaBazaarApp
{
    public partial class EndContract : Form
    {
        Employee empl;
        public EndContract(Employee empl)
        {
            InitializeComponent();
            this.empl = empl;
        }

        private void btnEndContract_Click(object sender, EventArgs e)
        {

            EmployeeEmploymentInformation emplInfo = empl.employmentInfo;
            if (String.IsNullOrWhiteSpace(tbEndReason.Text))
            {
                MessageBox.Show("Please fill in end reason.");
                return;
            }
            try
            {
                emplInfo.GetActiveContract().EndDate = dateTimePickerEndDate.Value;
                emplInfo.GetActiveContract().EndReason = tbEndReason.Text;
                emplInfo.GetActiveContract().IsActive = false;
                MessageBox.Show($"{empl.FirstName}'s contract was ended with date: {dateTimePickerEndDate.Value}");
                this.Close();
            }
            catch (InvalidEndDateEx ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
