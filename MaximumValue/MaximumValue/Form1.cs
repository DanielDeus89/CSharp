using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximumValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Maximum(double x, double y, double z)
        {
            return Math.Max(x, Math.Max(y, z));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Double.Parse(firstNumberTextBox.Text);
            double number2 = Double.Parse(secondNumberTextBox.Text);
            double number3 = Double.Parse(thirdNumberTextBox.Text);

            double maximum = Maximum(number1, number2, number3);

            maximumLabel.Text = "Maximum is: " + maximum;
        }
    }
}
