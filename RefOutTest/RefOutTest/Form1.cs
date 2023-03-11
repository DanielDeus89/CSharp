using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefOutTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void SquareRef(ref int x)
        {
            x = x * x;
        }
        void SquareOut(out int x)
        {
            x = 6;
            x = x * x;
        }
        void Square(int x)
        {
            x = x * x;
        }

        private void showOutputButton_Click(object sender, EventArgs e)
        {
            int y = 5;
            int z;

            outputLabel.Text = "Original value of y: " + y + "\n";
            outputLabel.Text += "Original value of z: unitialized \n\n";

            SquareRef(ref y);
            SquareOut(out z);

            outputLabel.Text += "value of y after SquareRef " + y + "\n";
            outputLabel.Text += "value of z after SquareOut " + z + "\n\n";

            Square( y);
            Square( z);


            outputLabel.Text += "value of y after Square " + y + "\n";
            outputLabel.Text += "value of z after Square " + z + "\n\n";


        }
    }
}
