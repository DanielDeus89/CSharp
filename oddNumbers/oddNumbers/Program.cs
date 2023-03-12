/*
Escreva um programa que imprima todos os números ímpares entre 1 e 100, exceto os múltiplos de 3. 
Use uma estrutura de repetição e as operações lógicas que você aprendeu até agora. Boa sorte!

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                if((i % 2 != 0) && (i % 3 != 0))
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
