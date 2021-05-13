using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int counter2 = 0;
        int counter3 = 0;
        int status = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            status++;
            if(status % 2 == 0)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 59)
            {
                counter = 0;
                counter2++;
            }
            if (counter2 > 59)
            {
                counter2 = 0;
                counter3++;
            }
            label1.Text = $"{counter3:00}:{counter2:00}:{counter:00}";
        }
    }
}
