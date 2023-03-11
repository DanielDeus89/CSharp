using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random randomNumber = new Random();


        private void rollButton_Click(object sender, EventArgs e)
        {
            DisplayDie(dieLabel1);
            DisplayDie(dieLabel2);
            DisplayDie(dieLabel3);
            DisplayDie(dieLabel4);

   
        }

        public void DisplayDie(Label dieLabel)
        {
          

            int face = randomNumber.Next(1, 7);

            dieLabel.Image = Image.FromFile(
                Directory.GetCurrentDirectory() +
                "\\images\\die" + face + ".gif");
        }

        private void dieLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
