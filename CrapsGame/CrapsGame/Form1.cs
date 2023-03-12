using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int myPoint;
        int myDie1;
        int myDie2;

        public enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            YO_LEVEN = 11,
            BOX_CARS = 12,
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int sum = rollDice();
        }

        private int rollDice()
        {
            int die1, die2, dieSum;
            Random randomNumber = new Random();

            die1 = randomNumber.Next(1, 7);
            die2 = randomNumber.Next(1, 7);

            displayDie(firsDieImage, die1);

            return dieSum;
        }
    }
}
