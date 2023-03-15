using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacoesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] listNumeros = { 5, 1, 2, 3, 4, 5 };

        int somar(int[] list)
        {
            int somar = 0;
            foreach(int numero in list)
            {
                somar += numero;
            }
            return somar;
        }

        int sub(int[] list)
        {
            int sub = 0;
            foreach(int numero in list)
            {
                sub -= numero;
            }
            return sub;
        }
        int div(int[] list)
        {
            int div = 1;

            foreach(int numero in list)
            {
                if (div == 0)
                {
                    throw new DivideByZeroException();
                }
                div /= numero;
            }
            return div;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string operador = txtOperador.Text;

            if(operador == "+")
            {
                int resultado = somar(listNumeros);
                lblResultado.Text = resultado.ToString("0.#####");
            }else if(operador == "-")
            {
                int resultado = sub(listNumeros);
                lblResultado.Text = resultado.ToString("0.#####");
            }else if(operador == "/")
            {
                int resultado = div(listNumeros);
                lblResultado.Text = resultado.ToString("F3");
            }
            
        }
    }
}
