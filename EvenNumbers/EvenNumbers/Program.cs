/*
Desafio: Crie um programa que receba um número inteiro e imprima na tela todos os números pares de 0 até esse número (inclusive).
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter an Integer Number: ");
            number = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadKey();
        }
    }
}
