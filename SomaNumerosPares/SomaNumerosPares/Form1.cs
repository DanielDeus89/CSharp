/*
 * Desafio: Criar um programa que receba uma lista de números inteiros e 
 * retorne a soma de todos os números pares da lista.
 * */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaNumerosPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numeros = new List<int>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string entrada = txtNumeros.Text.Trim();
            string[] numerosString = entrada.Split(' ');

            foreach(string numeroString in numerosString)
            {
                int numero;
                if(int.TryParse(numeroString, out numero))
                {
                    numeros.Add(numero);
                }
            }
            txtNumeros.Text = " ";
            txtNumeros.Focus();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    soma += numero;
                    lblResultado.Text = "Soma dos Pares: " + soma;

                }

            }

        }
    }
}
