/*
 string imagePath = Directory.GetCurrentDirectory() + "\\images\\die" + i + ".gif";
Image image = Image.FromFile(imagePath);
lblOutput.Controls.Add(new PictureBox { Image = image, Width = image.Width, Height = image.Height });

 * 
 */


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

namespace RollDieChallenge2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRollDie_Click(object sender, EventArgs e)
        {
            Random rdNumber = new Random();
            int numDados = int.Parse(txtDados.Text);

            // Limpa os controles de imagem existentes
            lblOutput.Controls.Clear();

            for (int i = 1; i <= numDados; i++)
            {
                int resultado = rdNumber.Next(1, 7);
                string imagePath = Directory.GetCurrentDirectory() + "\\images\\die" + resultado + ".gif";
                Image image = Image.FromFile(imagePath);
                PictureBox pictureBox = new PictureBox
                {
                    Image = image,
                    Width = image.Width,
                    Height = image.Height,
                    Padding = new Padding(5)
                };
                lblOutput.Controls.Add(pictureBox);
            }
        }
    }
}
