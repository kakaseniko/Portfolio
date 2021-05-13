using Classes;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopManagement
{
    public partial class PersonsWsForm : Form
    {
        Person person;
        public PersonsWsForm(Person p)
        {
            InitializeComponent();
            this.person = p;
            lblPersInfo.Text = $"{person.FirstName} {person.LastName}: {person.PCN}";
            UpdateLB();
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if(listBoxEnrolledWs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a workshop.");
                return;
            }
            try
            {
                person.RemoveAttendance(((Attendance)listBoxEnrolledWs.SelectedItem).Wks);
                ((Attendance)listBoxEnrolledWs.SelectedItem).Wks.RemoveParticipant(person);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateLB();
        }

        //METHODS

        private void UpdateLB()
        {
            listBoxEnrolledWs.Items.Clear();
            if(person.GetAttendances() == null)
            {
                listBoxEnrolledWs.Items.Add("No enrolled workshops.");
                return;
            }
            foreach(Attendance a in person.GetAttendances())
            {
                listBoxEnrolledWs.Items.Add(a);
            }
        }
    }
}
