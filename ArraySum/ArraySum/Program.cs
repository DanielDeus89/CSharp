/*
 * Nome do arquivo: ArraySum.cs

Desafio: Escreva um programa que inicialize um array de números inteiros e calcule a soma de todos os elementos do array. O programa deve imprimir o array e o resultado da soma na tela.

Requisitos:

O programa deve inicializar um array com pelo menos 5 números inteiros de sua escolha.
O programa deve calcular a soma de todos os elementos do array.
O programa deve imprimir o array e o resultado da soma na tela.
Exemplo de saída:

Array: 1 2 3 4 5
Sum: 15


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[] numbers = {1,2,3,4,5};
            
            foreach (int number in numbers)            
                sum += number;


            Console.WriteLine("Array:" + string.Join(" ", numbers));
            Console.WriteLine("Sum:{0}", sum);
            Console.ReadKey();
        }
    }
}
