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
        string operacao;
        string primeiroValor;
        string segundoValor;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }


        private void btnSomar_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            operacao = "+";
        }
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            operacao = "-"; 
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            operacao = "*";
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            operacao = "/";
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            segundoValor = txtValor.Text;
            txtValor.Text = "";
            switch (operacao)
            {
                case "+":
                    resultado = Convert.ToDouble(primeiroValor) + Convert.ToDouble(segundoValor);
                    break;
                case "-":
                    resultado = Convert.ToDouble(primeiroValor) - Convert.ToDouble(segundoValor);
                    break;
                case "*":
                    resultado = Convert.ToDouble(primeiroValor) * Convert.ToDouble(segundoValor);
                    break;
                case "/":
                    resultado = Convert.ToDouble(primeiroValor) / Convert.ToDouble(segundoValor);
                    break ;
            }
            txtValor.Text = resultado.ToString();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            primeiroValor = "";
            segundoValor = "";
            txtValor.Text = "";
        }


    }
}
