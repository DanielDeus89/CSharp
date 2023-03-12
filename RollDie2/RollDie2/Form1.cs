using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random randomNumber = new Random();
        private int ones, twos, threes, fours, fives, sixes;

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDie(dieLabel1);
            DisplayDie(dieLabel2);
            DisplayDie(dieLabel3);
            DisplayDie(dieLabel4);
            DisplayDie(dieLabel5);
            DisplayDie(dieLabel6);
            DisplayDie(dieLabel7);
            DisplayDie(dieLabel8);
            DisplayDie(dieLabel9);
            DisplayDie(dieLabel10);
            DisplayDie(dieLabel11);
            DisplayDie(dieLabel12);

            double total = ones + twos + threes + fours + fives + sixes;

            displayTextBox.Text = "Face\t\tFrequency\tPercent"+
                "\n1\t\t" + ones + "\t\t" + String.Format("{0:F2}", ones / total * 100) + 
                "%\n2\t\t" + twos + "\t\t" + String.Format("{0:F2}", twos / total *100) +
                "%\n3\t\t" + threes + "\t\t" + String.Format("{0:F2}", threes / total *100) +
                "%\n4\t\t" + fours + "\t\t" + String.Format("{0:F2}", fours / total *100) +
                "%\n5\t\t" + fives + "\t\t" + String.Format("{0:F2}", fives / total *100) +
                "%\n6\t\t" + sixes + "\t\t" + String.Format("{0:F2}", sixes / total *100) + "%";
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomNumber.Next(1, 7);

            dieLabel.Image = Image.FromFile(
                Directory.GetCurrentDirectory() +
                "\\images\\die" + face + ".gif");

            switch (face)
            {
                case 1:
                    ones++;
                    break;

                case 2:
                    twos++;
                    break;

                case 3:
                    threes++;
                    break;

                case 4:
                    fours++;
                    break;

                case 5:
                    fives++;
                    break;

                case 6:
                    sixes++;
                    break;
            }
        }
    }
}
