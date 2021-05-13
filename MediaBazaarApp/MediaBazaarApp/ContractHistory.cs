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

namespace MediaBazaarApp
{
    public partial class ContractHistory : Form
    {
        Employee empl;
        public ContractHistory(Employee empl)
        {
            InitializeComponent();
            this.empl = empl;
            UpdateLBContractHistory();
        }
        private void UpdateLBContractHistory()
        {
            lbContractHistory.Items.Clear();
            foreach(EmployeeContract c in empl.employmentInfo.GetContractHistory().ToList())
            {
                lbContractHistory.Items.Add(c);
            }
        }
    }
}
