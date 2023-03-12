/*
Desafio: Escreva um programa que imprima todos os números primos entre 1 e 100 na tela.

Requisitos:

O programa deve imprimir apenas números primos.
O programa deve imprimir os números na ordem em que são encontrados.
Os números devem ser separados por espaços.
O programa deve imprimir um número por linha.
Exemplo de saída:

2
3
5
7
11
...
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 100; i++)
            {

                bool isPrime = true;

                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {

                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
