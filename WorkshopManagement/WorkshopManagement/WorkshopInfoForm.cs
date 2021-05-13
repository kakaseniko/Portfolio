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
    public partial class WorkshopInfoForm : Form
    {
        IWorkshopCRUDLogic wscrudlogic;
        IWorkshopLogic wslogic;
        Workshop ws;
        public WorkshopInfoForm(IWorkshopCRUDLogic wscrudlogic, IWorkshopLogic wslogic, Workshop ws)
        {
            InitializeComponent();
            this.wscrudlogic = wscrudlogic;
            this.ws = ws;
            this.wslogic = wslogic;

            if(ws is OnlineWks)
            {
                lblWsInfo.Text = $"Date: {ws.Time}\nTitle: {ws.Title}\nTopic: {ws.Topic}\nCapacity: {ws.MaxParticipants}\nTeacher: {ws.Teacher}\nLink: {((OnlineWks)ws).Link}";
            }
            else
            {
                lblWsInfo.Text = $"Date: {ws.Time}\nTitle: {ws.Title}\nTopic: {ws.Topic}\nCapacity: {ws.MaxParticipants}\nTeacher: {ws.Teacher}\nAddress: {((InBuildingWks)ws).Address}\nRoom: {((InBuildingWks)ws).RoomNum}";
            }
            
            FillParticipantsLB();
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if(listBoxParticipants.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a participant.");
                return;
            }
            try
            {
                wslogic.RemoveParticipantFromWks(ws, (Person)listBoxParticipants.SelectedItem);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FillParticipantsLB();
        }
        private void btnPrintParticipantList_Click(object sender, EventArgs e)
        {
            string filename;
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;
                wscrudlogic.WriteOneWorkshopToFile(filename, ws);
            }
        }
        private void btnStartWks_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to start the workshop?";
            string caption = "Start workshop";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                wslogic.StartWks(ws);
                MessageBox.Show("Workshop has been started.");
            }
        }
        

        //METHODS
        private void FillParticipantsLB()
        {
            listBoxParticipants.Items.Clear();
            if(ws.GetParticipants() == null)
            {
                listBoxParticipants.Items.Add("No enrolled participants.");
                return;
            }
            foreach(Person p in ws.GetParticipants())
            {
                listBoxParticipants.Items.Add(p);
            }
        }

        
    }
}
