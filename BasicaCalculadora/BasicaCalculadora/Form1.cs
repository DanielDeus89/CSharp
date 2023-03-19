using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado = 0;
        string primeiroValor;
        string segundoValor;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn2.Text;

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            resultado += Convert.ToDouble(primeiroValor);
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundoValor = txtValor.Text;
            txtValor.Text = "";
            resultado += Convert.ToDouble(primeiroValor) + Convert.ToDouble(segundoValor);
            txtValor.Text = resultado.ToString();
        }
    }
}
