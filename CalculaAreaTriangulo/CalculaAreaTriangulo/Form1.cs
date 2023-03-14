/*
Desafio: Calcular a área de um triângulo a partir das medidas de seus lados.

btnCalcularArea
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaAreaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Area(double ladoA, double ladoB, double ladoC)
        {
            double s = (ladoA + ladoB + ladoC) / 2;
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double numberA = Double.Parse(txtLadoA.Text);
            double numberB = Double.Parse(txtLadoB.Text);
            double numberC = Double.Parse(txtLadoC.Text);

            double resultado = Area(numberA, numberB, numberC);

            lblResult.Text = "Area do Triangulo: " + resultado.ToString("F2");
        }
    }
}
