using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using ModulesAndInterfaces;

namespace MediaBazaarApp
{
    public partial class Login : Form
    {
        List<Employee> employees;
        //EmployeeDBManager db;
        private EmployeeManager em = new EmployeeManager();

        public Login()
        {
            InitializeComponent();
            //db = new EmployeeDBManager();
            //employees = db.ReadFromDB();
            em.ReadEmployeesFromDB();
            employees = em.GetEmployees().ToList();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxUsername.Text) || String.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Please, fill out all the required fields!");
            }
            else
            {
                string username = tbxUsername.Text;
                string password = tbxPassword.Text;
                bool invalid = true;

                foreach (Employee empl in employees)
                {
                    if (empl.personalInfo.Email == username && empl.personalInfo.Password == password)
                    {
                        EmployeeDepartment ed = empl.employmentInfo.EmployeeDepartment;

                        invalid = false;

                        this.Hide();
                        MediaBazaarForm form1 = new MediaBazaarForm(ed, empl);
                        form1.ShowDialog();
                        this.Close();
                    }
                }

                if (invalid)
                {
                    MessageBox.Show("Invalid data!");
                }

            }
        }
    }
}
