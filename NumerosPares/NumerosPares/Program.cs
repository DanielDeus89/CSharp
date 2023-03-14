/*
Desafio: Escreva um programa que solicite ao usuário para digitar um número inteiro positivo e imprima na tela todos os números pares entre 0 e o número digitado. 
Se o número digitado for negativo ou zero, o programa deve exibir uma mensagem de erro e solicitar um novo número.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Insira um Numero inteiro positivo: ");
            number = Int32.Parse(Console.ReadLine());

            while (number <= 0)
            {
                Console.WriteLine("Erro: o número deve ser positivo");

                Console.Write("Insira um Numero inteiro positivo: ");
                number = Int32.Parse(Console.ReadLine());


                Console.WriteLine($"Números pares entre 0 e {number}:");
                for (int i = 0; i <= number; i++)
                {
                    if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                   }

            }
            Console.ReadKey();
        }
    }
}
