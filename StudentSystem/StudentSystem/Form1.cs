using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class Form1 : Form
    {
        Administration a = new Administration();

        int age;
        int year;
        int pcnAddForm;
        double salary;
        int ecsAddForm;
        int pcn;
        public Form1()
        {
            InitializeComponent();
            rbStu.Checked = true;
            comboBox1.SelectedIndex = 0;
          
        }
        private void rbStu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStu.Checked)
            {
                tbECs.Enabled = true;
                tbSalary.Enabled = false;
            }
            else
            {
                tbECs.Enabled = false;
                tbSalary.Enabled = true;
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            InputCheck();
            if(rbStu.Checked)
            {
                if (String.IsNullOrWhiteSpace(tbECs.Text))
                {
                    MessageBox.Show("Please fill in ECs.");
                }
                else if (Int32.TryParse(tbECs.Text, out ecsAddForm) == false)
                {
                    MessageBox.Show("ECs must be numeric!");
                }
                else
                {
                    a.AddPerson(new Student( tbName.Text, age, pcnAddForm, year, ecsAddForm));
                }
            }
            else
            {
                if (String.IsNullOrWhiteSpace(tbSalary.Text))
                {
                    MessageBox.Show("Please fill in Salary.");
                }
                else if (Double.TryParse(tbSalary.Text, out salary) == false)
                {
                    MessageBox.Show("Salary must be numeric!");
                }
                else
                {
                    a.AddPerson(new Teacher( tbName.Text, age, pcnAddForm, year, salary));
                }
            }          
        }
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            List<Person> people = a.GetAllPersons();
            people.Sort();
            listBox1.Items.Clear();
            if(comboBox1.SelectedIndex == 0)
            {
                
                foreach(Person p in people)
                {
                    if(p is Student)
                    {
                        listBox1.Items.Add(((Student)p).ToString());
                        
                    }
                    else
                    {
                        listBox1.Items.Add(((Teacher)p).ToString());
                    }                                                      
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (Person p in people)
                {
                    if(p is Student)
                    {
                        listBox1.Items.Add(((Student)p).ToString());
                    }                   
                }
            }
            else
            {
                foreach(Person p in people)
                {
                    if(p is Teacher)
                    {
                        listBox1.Items.Add(((Teacher)p).ToString());
                    }
                }
            }           
        }      
        private void btnShowInfoStudentForm_Click(object sender, EventArgs e)
        {
            InputCheckPCN();
            if (a.GetPerson(pcn) == null)
            {
                MessageBox.Show("No person was found with this PCN.");
                return;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add(a.GetPerson(pcn).ToString());
        }
       
        private void btnStartNewYearStuFrom_Click(object sender, EventArgs e)
        {
            InputCheckPCN();
            a.GetPerson(pcn).StartAnotherSchoolYear();
        }
       
        private void btnAddECs_Click(object sender, EventArgs e)
        {
            InputCheckPCN();
            int addEC;
            if(String.IsNullOrWhiteSpace(tbAddECs.Text))
            {
                MessageBox.Show("Please fill in ECs.");
                return;
            }
            if(!Int32.TryParse(tbAddECs.Text, out addEC))
            {
                MessageBox.Show("ECs have to be numeric.");
                return;
            }
            if(a.GetPerson(pcn) == null || !(a.GetPerson(pcn) is Student))
            {
                MessageBox.Show("No student was found with this pcn.");
                return;
            }
            ((Student)a.GetPerson(pcn)).AddECs(addEC);

        }
        private void btnPromote_Click(object sender, EventArgs e)
        {
            InputCheckPCN();
            if(a.GetPerson(pcn) == null || !(a.GetPerson(pcn) is Teacher))
            {
                MessageBox.Show("No teacher was found with this pcn.");
                return;
            }
            ((Teacher)a.GetPerson(pcn)).MakePromotion();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("Please fill in partial name.");
                return;
            }
            if (a.SearchPerson(tbSearch.Text) == null )
            {
                MessageBox.Show("No person was found with this partial name.");
                return;
            }
            listBox1.Items.Clear();
            a.SearchPerson(tbSearch.Text).Sort();
            foreach (Person p in a.SearchPerson(tbSearch.Text))
            {
                listBox1.Items.Add(p);
            }
        }
        private void btnCelebrate_Click(object sender, EventArgs e)
        {
            InputCheckPCN();
            if (a.GetPerson(pcn) == null)
            {
                MessageBox.Show("No person was found with this pcn.");
                return;
            }
            a.GetPerson(pcn).CelebrateBirthday();

        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            a.SaveDataToDatabase();
        }
        //METHODS

        private void InputCheck()
        {
            if(String.IsNullOrWhiteSpace(tbAge.Text) || String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(tbPCNAddFrom.Text) || String.IsNullOrWhiteSpace(tbYear.Text))
            {
                MessageBox.Show("Please enter name, age, pcn and year.");
            }
            else if(Int32.TryParse(tbAge.Text, out age) == false || Int32.TryParse(tbYear.Text, out year) == false || Int32.TryParse(tbPCNAddFrom.Text, out pcnAddForm) == false)
            {
                MessageBox.Show("Age, year and PCN must be numeric!");
            }
        }
        private void InputCheckPCN()
        {
            if (String.IsNullOrWhiteSpace(tbPCNStudentForm.Text))
            {
                MessageBox.Show("Please fill in PCN.");
                return;
            }
            if (!Int32.TryParse(tbPCNStudentForm.Text, out pcn))
            {
                MessageBox.Show("PCN has to be numeric.");
            }
        }


    }
}
