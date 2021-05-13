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
    public partial class ReceptionistForm : Form
    {
        IWorkshopLogic wslogic;
        IWorkshopCRUDLogic wscrudlogic;
        IPersonLogic personlogic;
        IEnrollmentRequest enrollmentreq;
        public ReceptionistForm()
        {
            InitializeComponent();
            wslogic = new WorkshopLogic();
            wscrudlogic = new WorkshopCRUDLogic();
            personlogic = new PersonLogic();
            enrollmentreq = new EnrollmentRequestLogic();

            PersonalForm pf = new PersonalForm(wslogic, wscrudlogic, personlogic, enrollmentreq);
            pf.Show();
            comboBoxTypeWsMan.SelectedIndex = 0;
            comboBoxPersonRole.SelectedIndex = 0;

            enrollmentreq.EnrollmentRequestEvent += new IEnrollmentRequest.EnrollmentRequestHandler(enrollmentrequest_notification);

            //Dummy data
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            personlogic.AddPerson(new Student("Sarah", "Student", "159359"));
            wscrudlogic.AddWorkshop(new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink"));
            UpdateLBER();
            UpdateWSListbox();
            UpdatePeopleListbox();

        }
        #region PeopleManTab
        private void btnSavePaopleMan_Click(object sender, EventArgs e)
        {
            Person p = (Person)listBoxPeopleMan.SelectedItem;
            try
            {
                if(comboBoxPersonRole.SelectedIndex == 0)
                {
                    personlogic.EditPerson(p, new Student(textBoxFName.Text, textBoxLName.Text, textBoxPCN.Text));
                    
                }
                else
                {
                    personlogic.EditPerson(p, new Teacher(textBoxFName.Text, textBoxLName.Text, textBoxPCN.Text));
                }

                MessageBox.Show("Editing was successful.");
                textBoxFName.Text = "";
                textBoxLName.Text = "";
                textBoxPCN.Text = "";
                UpdatePeopleListbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPeopleMan_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPersonRole.SelectedIndex == 0)
                {
                    personlogic.AddPerson(new Student(textBoxFName.Text, textBoxLName.Text, textBoxPCN.Text));
                    
                }
                else
                {
                    personlogic.AddPerson(new Teacher(textBoxFName.Text, textBoxLName.Text, textBoxPCN.Text));
                    
                }
                UpdatePeopleListbox();
                textBoxFName.Text = "";
                textBoxLName.Text = "";
                textBoxPCN.Text = "";
                btnSavePaopleMan.Visible = false;
                btnAddPeopleMan.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditPeopleMan_Click(object sender, EventArgs e)
        {
            if(listBoxPeopleMan.SelectedIndex == -1)
            {
                MessageBox.Show("Select a person.");
                return;
            }
            Person p = (Person)listBoxPeopleMan.SelectedItem;
            if(p is Teacher)
            {
                comboBoxPersonRole.SelectedIndex = 1;
            }
            else
            {
                comboBoxPersonRole.SelectedIndex = 0;
            }
            textBoxFName.Text = p.FirstName;
            textBoxLName.Text = p.LastName;
            textBoxPCN.Text = p.PCN;

            btnSavePaopleMan.Visible = true;
            btnAddPeopleMan.Visible = false;           
        }
        private void listBoxPeopleMan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PersonsWsForm pwf = new PersonsWsForm((Person)listBoxPeopleMan.SelectedItem);
            pwf.Show();
        }
        //METHODS
        private void UpdatePeopleListbox()
        {
            listBoxPeopleMan.Items.Clear();
            comboBoxPeopleEnMan.Items.Clear();
            comboBoxteacherWsMan.Items.Clear();
            foreach (Person p in personlogic.GetPeople())
            {
                listBoxPeopleMan.Items.Add(p);
                comboBoxPeopleEnMan.Items.Add(p);
                if(p is Teacher)
                {
                    comboBoxteacherWsMan.Items.Add(p);
                }
            }
        }

        #endregion

        #region WorkshopManTab
        private void btnAddWs_Click(object sender, EventArgs e)
        {
            try
            {


                if (comboBoxteacherWsMan.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a teacher.");
                    return;
                }
                string title = tbTitleWsMan.Text;
                string topic = tbTopicWsMan.Text;
                int cap = Convert.ToInt32(numericUpDownCapacity.Value);
                Teacher teacher = (Teacher)comboBoxteacherWsMan.SelectedItem;
                DateTime date = dateTimePicker1.Value;
                string address = tbAddressWsMan.Text;
                int room = Convert.ToInt32(numericUpDownRoomNumber.Value);
                string link = tbLinkWsMan.Text;

                if (comboBoxTypeWsMan.SelectedIndex == 0)
                {
                    wscrudlogic.AddWorkshop(new InBuildingWks(title, topic, date, cap, teacher, address, room));

                }
                else
                {
                    wscrudlogic.AddWorkshop(new OnlineWks(title, topic, date, cap, teacher, link));
                }
                ClearTextboxes();
                UpdateWSListbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditWs_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (listBoxWorkshops.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a workshop.");
                    return;
                }
                Workshop ws = (Workshop)listBoxWorkshops.SelectedItem;
                if(ws.IsStarted)
                {
                    MessageBox.Show("This workshop has already been started. Editing is not possible anymore.");
                    return;
                }
                if (ws is InBuildingWks)
                {
                    comboBoxTypeWsMan.SelectedIndex = 0;
                    tbAddressWsMan.Text = ((InBuildingWks)ws).Address;
                    numericUpDownRoomNumber.Value = ((InBuildingWks)ws).RoomNum;
                }
                else
                {
                    comboBoxTypeWsMan.SelectedIndex = 1;
                    tbLinkWsMan.Text = ((OnlineWks)ws).Link;
                }
                tbTitleWsMan.Text = ws.Title;
                tbTopicWsMan.Text = ws.Topic;
                numericUpDownCapacity.Value = ws.MaxParticipants;
                comboBoxteacherWsMan.SelectedItem = ws.Teacher;
                dateTimePicker1.Value = ws.Time;
                btnAddWs.Visible = false;
                btnSaveWs.Visible = true;
                listBoxWorkshops.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRemoveWs_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxWorkshops.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a workshop.");
                    return;
                }
                wscrudlogic.RemoveWorkshop((Workshop)listBoxWorkshops.SelectedItem);
                UpdateWSListbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveWs_Click(object sender, EventArgs e)
        {
            

            Workshop oldws = (Workshop)listBoxWorkshops.SelectedItem;
            Workshop newws;
            string title = tbTitleWsMan.Text;
            string topic = tbTopicWsMan.Text;
            int cap = Convert.ToInt32(numericUpDownCapacity.Value);
            Teacher teacher = (Teacher)comboBoxteacherWsMan.SelectedItem;
            DateTime date = dateTimePicker1.Value;
            string address = tbAddressWsMan.Text;
            int room = Convert.ToInt32(numericUpDownRoomNumber.Value);
            string link = tbLinkWsMan.Text;
            try
            {
                if (comboBoxTypeWsMan.SelectedIndex == 0)
                {
                 newws = new InBuildingWks(title, topic, date, cap, teacher, address, room);

                }
                else
                {
                   newws = new OnlineWks(title, topic, date, cap, teacher, link);
                }
            
                wscrudlogic.EditWorkshop(oldws, newws);
                UpdateWSListbox();
                ClearTextboxes();
                listBoxWorkshops.Enabled = true;
                btnSaveWs.Visible = false;
                btnAddWs.Visible = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPrintWs_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                wscrudlogic.WriteAllWorkshopsToFile(filename);
            }
        }
        private void listBoxWorkshops_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WorkshopInfoForm wif = new WorkshopInfoForm(wscrudlogic, wslogic, (Workshop)listBoxWorkshops.SelectedItem);
            wif.FormClosed += new FormClosedEventHandler(WorkshopInfoForm_Closed);
            wif.Show();

        }
        //METHODS

        private void UpdateWSListbox()
        {
            listBoxWorkshops.Items.Clear();
            comboBoxWsEnMan.Items.Clear();
            foreach(Workshop w in wscrudlogic.GetAllWorkshops())
            {
                listBoxWorkshops.Items.Add(w);
                if (!w.IsStarted)
                {
                    comboBoxWsEnMan.Items.Add(w);
                }
            }
        }
        private void ClearTextboxes()
        {
            comboBoxTypeWsMan.SelectedIndex = 0;
            tbAddressWsMan.Text = "";
            numericUpDownRoomNumber.Value = 0;
            tbLinkWsMan.Text = "";
            tbTitleWsMan.Text = "";
            tbTopicWsMan.Text = "";
            numericUpDownCapacity.Value = 0;
            comboBoxteacherWsMan.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        #endregion

        #region EnrollmentTab
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if(comboBoxPeopleEnMan.SelectedIndex == -1 || comboBoxWsEnMan.SelectedIndex == -1)
            {
                MessageBox.Show("Please select person and workshop.");
                return;
            }
            try
            {
                wslogic.AddParticipantToWks((Workshop)comboBoxWsEnMan.SelectedItem, (Person)comboBoxPeopleEnMan.SelectedItem);
                MessageBox.Show("Enrollment was successful.");
                comboBoxPeopleEnMan.SelectedIndex = -1;
                comboBoxWsEnMan.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnApproveER_Click(object sender, EventArgs e)
        {
            if(listBoxEnrollementRequests.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a request.");
                return;
            }
            try
            {
                EnrollmentRequest er = (EnrollmentRequest)listBoxEnrollementRequests.SelectedItem;
                enrollmentreq.SetERStatus(er, "Approved");
                wslogic.AddParticipantToWks(er.Wks, er.Person);
                listBoxEnrollementRequests.Items.Remove(er);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnDenyER_Click(object sender, EventArgs e)
        {
            if (listBoxEnrollementRequests.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a request.");
                return;
            }
            EnrollmentRequest er = (EnrollmentRequest)listBoxEnrollementRequests.SelectedItem;
            enrollmentreq.SetERStatus(er, "Denied");
            listBoxEnrollementRequests.Items.Remove(er);
        }
        private void WorkshopInfoForm_Closed(object sender, FormClosedEventArgs e)
        {
            comboBoxWsEnMan.Items.Clear();
            foreach(Workshop w in wscrudlogic.GetAllWorkshops())
            {
                if(!w.IsStarted)
                {
                    comboBoxWsEnMan.Items.Add(w);
                }
            }
        }

        //METHODS
        private void enrollmentrequest_notification(EnrollmentRequest er)
        {
            listBoxEnrollementRequests.Items.Add(er);
        }
        private void UpdateLBER()
        {
            listBoxEnrollementRequests.Items.Clear();
            foreach(EnrollmentRequest er in enrollmentreq.GetAllER())
            {
                listBoxEnrollementRequests.Items.Add(er);
            }
        }






        #endregion

        
    }
}
