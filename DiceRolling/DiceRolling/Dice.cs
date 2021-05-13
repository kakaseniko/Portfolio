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
    public partial class Dice : Form
    {
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        public Dice()
        {
            InitializeComponent();
            Random num = new Random();
            int diceNum = num.Next(1, 7);

            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);

            foreach (PictureBox pic in pictureBoxes)
            {
                pic.Visible = false;
            }

            pictureBoxes[diceNum - 1].Visible = true;

        }
    }
}
