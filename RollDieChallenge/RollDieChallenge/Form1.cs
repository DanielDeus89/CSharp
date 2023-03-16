/* 
Desafio:
Crie um programa que simule um jogo de dados.
O programa deve solicitar ao usuário quantos dados serão lançados e quantas faces cada dado terá. 
Em seguida, deve exibir na tela o resultado de cada dado lançado e a soma total dos valores obtidos.

Exemplo de saída:

Quantos dados serão lançados? 3
Quantas faces cada dado terá? 6

Resultado dos dados lançados:
Dado 1: 3
Dado 2: 5
Dado 3: 1

Soma total: 9

Dica: Utilize um loop para lançar cada dado e somar os valores obtidos. 
Utilize o método Next da classe Random para gerar valores aleatórios para os dados.
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

namespace RollDieChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnRollDie_Click(object sender, EventArgs e)
        {
            Random randomInteger = new Random();

            lblOutput.Text = "";

            int dados = int.Parse(txtDados.Text);
            int faces = int.Parse(txtFaces.Text);

            int face = 0;
            int soma = 0;

            if (dados == 0)
            {
                lblOutput.Text = "valore in";
            }

            for (int i = 1; i <= dados; i++)
            {
               
                face = randomInteger.Next(1, faces+1);                    
                
                soma += face;

                lblOutput.Text += "Dado " + i + ":" + face + "\n";
            }
            lblOutput.Text += "\n\nSoma: " + soma.ToString();
        }
    }
}
