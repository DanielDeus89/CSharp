
/*
Escreva um programa que solicita ao usuário que digite uma frase e conte o número de ocorrências de cada vogal (a, e, i, o, u) na frase. 
O programa deve ignorar letras maiúsculas e minúsculas e exibir o resultado na tela.

Por exemplo, se o usuário digitar a frase "The quick brown fox jumps over the lazy dog", o programa deve exibir:

a: 1
e: 2
i: 1
o: 4
u: 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a Frase:");
            String input = Console.ReadLine().ToLower();

            int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;


            foreach (char letter in input)
            {
                switch (letter)
                {
                    case 'a':
                        aCount++;
                        break; 
                    case 'e':
                        eCount++;
                        break;
                    case 'i':
                        iCount++;
                        break;
                    case 'o':
                        oCount++;
                        break;
                    case 'u':
                        uCount++;
                        break;
                }
            }
            Console.WriteLine("a: {0}", aCount);
            Console.WriteLine("e: {0}", eCount);
            Console.WriteLine("i: {0}", iCount);
            Console.WriteLine("o: {0}", oCount);
            Console.WriteLine("u: {0}", uCount);
            Console.ReadKey();
        }
    }
}
