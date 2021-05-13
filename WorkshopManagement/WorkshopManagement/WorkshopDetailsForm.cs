using Classes;
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
    public partial class WorkshopDetailsForm : Form
    {
        Workshop w;
        public WorkshopDetailsForm(Workshop w)
        {
            InitializeComponent();
            this.w = w;
            FillWorkshopDetails();
        }
        private void FillWorkshopDetails()
        {
            string[] row;
            if(w is InBuildingWks)
            {
                row = new string[] { w.Time.ToString(), w.Title, w.Topic, w.Teacher.ToString(),w.MaxParticipants.ToString(), ((InBuildingWks)w).Address, ((InBuildingWks)w).RoomNum.ToString()};
            }
            else
            {
                row = new string[] { w.Time.ToString(), w.Title, w.Topic, w.Teacher.ToString(), w.MaxParticipants.ToString(), "", "", ((OnlineWks)w).Link};
            }
            
            var lvi = new ListViewItem(row);
            lvi.Tag = w;
            listView1.Items.Add(lvi);
        }
    }
}
