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
        private void adicionarNumero(string numero)
        {
            txtValor.Text += numero;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtValor.Text += btn9.Text;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            resultado = Math.Sqrt(Convert.ToDouble(primeiroValor));
            txtValor.Text = resultado.ToString();
        }
    }
}
