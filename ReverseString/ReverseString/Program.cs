/*
Nome do arquivo: ReverseString.cs

Desafio: Escreva um programa que solicite ao usuário que digite uma string e, em seguida, imprima a string invertida na tela. Por exemplo, se o usuário digitar "hello", o programa deve imprimir "olleh".

Requisitos:

O programa deve solicitar ao usuário que digite uma string.
O programa deve imprimir a string invertida na tela.
O programa deve lidar com strings de comprimento variável.

Exemplo de saída:

Digite uma string: programming
A string invertida é: gnimmargorp
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            String input = Console.ReadLine();

            char[] charArray = input.ToCharArray();

            Array.Reverse(charArray);

            String reversedString = string.Join("", charArray);

            Console.WriteLine("The Inverted String is: {0}", reversedString);
            Console.ReadKey();

        }
    }
}
