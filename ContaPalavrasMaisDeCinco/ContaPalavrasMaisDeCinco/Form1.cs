/*
Desafio: 
criar um programa que receba uma lista de palavras e retorne a quantidade de palavras que possuem mais de 5 caracteres. 
Nome sugerido para o arquivo: ContaPalavrasMaisDeCinco.cs.
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

namespace ContaPalavrasMaisDeCinco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> palavras = new List<string>();

        private void lblAdicionar_Click(object sender, EventArgs e)
        {
            string entrada = txtFrase.Text;
            string[] fraseString = entrada.Split(' ');

            palavras.Clear();

            foreach(string palavra in fraseString)
            {
                palavras.Add(palavra);
            }

            txtFrase.Text = "";
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach(string palavra in palavras)
            {
                if (palavra.Length > 5)
                {
                    count++;
                }

            }

            lblResultado.Text = "Quantidade de palavras com mais de 5 caracteres: " + count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
