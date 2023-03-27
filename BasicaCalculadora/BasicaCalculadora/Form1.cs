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

        private void adicionarNumero(string numero)
        {
            string currentNumber = txtValor.Text;

            if (currentNumber.Length > 0 && currentNumber[0] == '0')
            {
                txtValor.Text = "";
                txtValor.Text += numero;
            }
            else
            {
                txtValor.Text += numero;

            }
        }

        double resultado = 0;
        string operacao;
        string primeiroValor;
        string segundoValor;

        private void btnSomar_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            lblPrimeiro.Text = primeiroValor;
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
                    lblPrimeiro.Text = primeiroValor + " + " + segundoValor + " = ";
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
            adicionarNumero(btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            adicionarNumero(btn9.Text);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            primeiroValor = txtValor.Text;
            txtValor.Text = "";
            resultado = Math.Sqrt(Convert.ToDouble(primeiroValor));
            txtValor.Text = resultado.ToString();
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string currentNumber = txtValor.Text;
            if(currentNumber.Length > 0)
            {
                currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                txtValor.Text = currentNumber;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string currentNumber = txtValor.Text;
            if(currentNumber.Length == 0)
            {
                txtValor.Text = "0";
            }
            else if (currentNumber.Length == 1 && currentNumber[0] == '0')
            {
            }
            else
            {
                txtValor.Text += "0";

            }
        }
    }
}
