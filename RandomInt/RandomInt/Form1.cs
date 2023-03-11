using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            Random randomInteger = new Random();

            outputLabel.Text = "";

            for(int counter = 1; counter <= 20; counter++)
            {
                int nextValue = randomInteger.Next(1, 7);

                outputLabel.Text += nextValue + "     ";

                if(counter % 5 == 0)
                {
                    outputLabel.Text += "\n";
                }
            }

        }
    }
}
