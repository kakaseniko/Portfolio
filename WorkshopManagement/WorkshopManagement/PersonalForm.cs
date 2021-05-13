using Classes;
using Interfaces;
using Logic;
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
    public partial class PersonalForm : Form
    {
        IWorkshopLogic wslogic;
        IWorkshopCRUDLogic wscrudlogic;
        IPersonLogic personlogic;
        IEnrollmentRequest erlogic;
        Person person;
        public PersonalForm(IWorkshopLogic wslogic, IWorkshopCRUDLogic workshopcrudlogic, IPersonLogic personlogic, IEnrollmentRequest er)
        {
            InitializeComponent();
            this.wslogic = wslogic;
            this.wscrudlogic = workshopcrudlogic;
            this.personlogic = personlogic;
            this.erlogic = er;
            
            erlogic.EnrollmentRequestStatusChangeEvent += new IEnrollmentRequest.EnrollmentRequestStatusHandler(erstatuschange_notification);
            wslogic.ParticipantsLimitEvent += new IWorkshopLogic.ParticipantsLimitHandler(partlimit_notification);

        }
        private void btnLoadPeople_Click(object sender, EventArgs e)
        {
            FillPeopleCBB();
            FillAvWksListBox();
        }
        private void comboBoxPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            person = (Person)comboBoxPeople.SelectedItem;
            FillMyWks(person);
            listBoxNotifications.Items.Clear();
        }
        private void btnEnrollmentRequest_Click(object sender, EventArgs e)
        {
            if(comboBoxPeople.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a person.");
                return;
            }
            if(listBoxAvWs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a workshop.");
                return;
            }
            try
            {
                erlogic.AddER(new EnrollmentRequest((Workshop)listBoxAvWs.SelectedItem, person));
                MessageBox.Show("Enrollment request was sent.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSeen_Click(object sender, EventArgs e)
        {
            if(listBoxNotifications.SelectedIndex == -1)
            {
                MessageBox.Show("Select a notification.");
                return;
            }
            listBoxNotifications.Items.Remove(listBoxNotifications.SelectedItem);
        }
        private void btnSeeDetails_Click(object sender, EventArgs e)
        {
            if (listBoxMyWs.SelectedIndex == -1)
            {
                MessageBox.Show("Select a workshop.");
                return;
            }
            WorkshopDetailsForm wdf = new WorkshopDetailsForm(((Attendance)listBoxMyWs.SelectedItem).Wks);
            wdf.Show();
        }

        //METHODS
        private void FillPeopleCBB()
        {
            comboBoxPeople.Items.Clear();
            foreach(Person p in personlogic.GetPeople())
            {
                comboBoxPeople.Items.Add(p);
            }
        }

        private void FillAvWksListBox()
        {
            listBoxAvWs.Items.Clear();
            if(wscrudlogic.GetAllWorkshops() ==  null)
            {
                listBoxAvWs.Items.Add("No available workshop.");
                return;
            }
            foreach(Workshop w in wscrudlogic.GetAllWorkshops())
            {
                if(!w.IsStarted)
                {
                    listBoxAvWs.Items.Add(w);
                }
            }
        }
        private void FillMyWks(Person p)
        {
            listBoxMyWs.Items.Clear();
            if(p.GetAttendances() == null)
            {
                listBoxMyWs.Items.Add("No enrolled workshops.");
                return;
            }
            foreach(Attendance a in p.GetAttendances())
            {               
                listBoxMyWs.Items.Add(a);               
            }
        }
        private void erstatuschange_notification(EnrollmentRequest er)
        {
            if(er.Person == person)
            {
                listBoxNotifications.Items.Add($"Workshop: {er.Wks.Title}, Enrollment request: {er.Status}");
                FillMyWks(er.Person);
            }
            

        }
        private void partlimit_notification(Workshop w)
        {
            listBoxNotifications.Items.Add($"Workshop '{w.Title}' is almost full!");
        }

        
    }
}
