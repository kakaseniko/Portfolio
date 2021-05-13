using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRolling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int dices = Convert.ToInt32(numericUpDown1.Value);

            for(int i = 0; i < dices; i++)
            {
                Dice childform = new Dice();
                childform.Show();
            }
            
        }

        
    }
}
