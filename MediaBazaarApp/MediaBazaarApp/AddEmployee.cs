using MySql.Data.MySqlClient;
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
    public partial class AddEmployee : Form
    {
        EmployeeManager em;
        Employee empl;
        int newEmplNum;
        public AddEmployee(EmployeeManager em)
        {
            InitializeComponent();
            this.em = em;
            comboBoxDepartment.DataSource = Enum.GetNames(typeof(EmployeeDepartment));
            newEmplNum = 1000 + em.GetEmployees().Length + 1;

        }
        public AddEmployee(EmployeeManager em, Employee empl)
        {
            InitializeComponent();
            this.em = em;
            this.empl = empl;

            comboBoxDepartment.DataSource = Enum.GetNames(typeof(EmployeeDepartment));
            lbEmplNum.Text = empl.EmployeeNumber.ToString();
            btnEnd.Visible = true;
            btnEditContract.Visible = true;
            btnViewContractHistory.Visible = true;
            numericUpDownHoursPerWeek.Enabled = false;
            numericUpDownSalary.Enabled = false;
            dtpStartDate.Enabled = false;

            tbxFirstName.Text = empl.FirstName;
            tbxLastName.Text = empl.LastName;
            dtpDateOfBirth.Value = empl.personalInfo.DateOfBirth;
            tbxPhoneNumber.Text = empl.personalInfo.PhoneNumber;
            tbxBSN.Text = empl.personalInfo.BSN;
            tbxEmail.Text = empl.personalInfo.Email;
            tbxEmergencyName.Text = empl.personalInfo.ICEName;
            tbxEmergencyPhone.Text = empl.personalInfo.ICEPhone;
            tbCity.Text = empl.personalInfo.Address.City;
            tbxStreetName.Text = empl.personalInfo.Address.StreetName;
            tbxStreetNumber.Text = empl.personalInfo.Address.StreetNum.ToString();
            tbxStreetNrAddition.Text = empl.personalInfo.Address.StreetNumAddition;
            tbxPostalCode.Text = empl.personalInfo.Address.Postcode;
            comboBoxDepartment.SelectedIndex = (int)empl.employmentInfo.EmployeeDepartment;

            if (empl.employmentInfo.GetActiveContract() == null)
            {
                lbEndDate.Text = "This employee has no active contract.";
                btnEnd.Visible = false;
                btnEditContract.Visible = false;
                btnSaveContract.Visible = false;
                btnAddNewContract.Visible = true;
            }
            else
            {
                numericUpDownHoursPerWeek.Value = Convert.ToDecimal(empl.employmentInfo.GetActiveContract().FTE);
                numericUpDownSalary.Value = Convert.ToDecimal(empl.employmentInfo.GetActiveContract().Salary);
                dtpStartDate.Value = empl.employmentInfo.GetActiveContract().StartDate;

                lbEndDate.Text = "";
                btnEnd.Visible = true;
                btnAddNewContract.Visible = false;
            }

        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string fn = tbxFirstName.Text;
                string ln = tbxLastName.Text;
                EmployeeDepartment ed = (EmployeeDepartment)comboBoxDepartment.SelectedIndex;
                double fte = Convert.ToDouble(numericUpDownHoursPerWeek.Value);
                double salary = Convert.ToDouble(numericUpDownSalary.Value);
                DateTime sd = dtpStartDate.Value;
                DateTime bd = dtpDateOfBirth.Value;
                string phone = tbxPhoneNumber.Text;
                string city = tbCity.Text;
                string streetname = tbxStreetName.Text;
                int streetnum = Convert.ToInt32(tbxStreetNumber.Text);
                string streetnumadd = tbxStreetNrAddition.Text;
                string postcode = tbxPostalCode.Text;
                string email = tbxEmail.Text;
                string bsn = tbxBSN.Text;
                string icename = tbxEmergencyName.Text;
                string icephone = tbxEmergencyPhone.Text;



                if (lbEmplNum.Text == "It will be generated automatically.")
                {

                    EmployeeEmploymentInformation emploInfo = new EmployeeEmploymentInformation(ed, new EmployeeContract(fte, salary, sd, newEmplNum, $"{newEmplNum}.{1}"));
                    EmployeePersonalInfo persInfo = new EmployeePersonalInfo(bd, phone, new Address(streetname, streetnum, streetnumadd, postcode, city), email, bsn, icename, icephone);
                    Employee employee = new Employee(fn, ln, emploInfo, persInfo, newEmplNum);
                    if (em.AddEmployee(employee))
                    {
                        MessageBox.Show("New employee was added successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                else
                {
                    empl.employmentInfo.EditActiveContract(new EmployeeContract(fte, salary, sd, empl.EmployeeNumber, empl.employmentInfo.GetActiveContract().ContractNum));
                    EmployeeEmploymentInformation emploInfo = new EmployeeEmploymentInformation(ed, empl.employmentInfo.GetContractHistory().ToList());
                    EmployeePersonalInfo persInfo = new EmployeePersonalInfo(bd, phone, new Address(streetname, streetnum, streetnumadd, postcode, city), email, bsn, icename, icephone);
                    Employee employee = new Employee(fn, ln, emploInfo, persInfo, empl.EmployeeNumber);
                    if (em.EditEmployee(this.empl, employee))
                    {
                        MessageBox.Show("Employee was edited successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
            }
            //catch (CustomeExeptions.InvalidPhoneNumEx ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (CustomeExeptions.InvalidEmailEx ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (CustomeExeptions.InvalidPostcodeEx ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (CustomExceptions.InvalidBSNEx ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEnd_Click(object sender, EventArgs e)
        {
            EndContract ecf = new EndContract(empl);
            ecf.FormClosed += new FormClosedEventHandler(EndContract_Closed);
            ecf.ShowDialog();
        }

        private void numericUpDownHoursPerWeek_ValueChanged(object sender, EventArgs e)
        {
            lblHours.Text = $"Hours/week: {ConvertFTEtoHours(Convert.ToDouble(numericUpDownHoursPerWeek.Value))}";
        }
        private double ConvertFTEtoHours(double fte)
        {
            return fte * 40;
        }

        private void btnAddNewContract_Click(object sender, EventArgs e)
        {
            numericUpDownHoursPerWeek.Enabled = true;
            numericUpDownSalary.Enabled = true;
            dtpStartDate.Enabled = true;
            btnSaveContract.Visible = true;
            btnSaveEmployee.Visible = false;
        }
        private void btnSaveContract_Click(object sender, EventArgs e)
        {
            if (em.AddNewContractToEmployee(empl, new EmployeeContract(Convert.ToDouble(numericUpDownHoursPerWeek.Value), Convert.ToDouble(numericUpDownSalary.Value), dtpStartDate.Value, empl.EmployeeNumber, $"{empl.EmployeeNumber}.{empl.employmentInfo.GetContractHistory().Length}")))
            {
                MessageBox.Show("Contract was saved successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }

        }
        private void btnEditContract_Click(object sender, EventArgs e)
        {
            numericUpDownHoursPerWeek.Enabled = true;
            numericUpDownSalary.Enabled = true;
            dtpStartDate.Enabled = true;
        }
        private void btnViewContractHistory_Click(object sender, EventArgs e)
        {
            ContractHistory chf = new ContractHistory(empl);
            chf.ShowDialog();
        }

        //METHODS
        private void EndContract_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


    }
}
