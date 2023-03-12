/*
Escreva um programa que solicite ao usuário para digitar 3 notas e calcule a média aritmética entre elas. 
Em seguida, o programa deve informar se a média é maior ou menor do que 7. 
Utilize as estruturas condicionais e de repetição que você aprendeu até o momento. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;

            double media;

            Console.Write("Primeira Nota:\t");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Segunda Nota:\t");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Terceira Nota:\t");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine(media);

            if (media < 7)
                Console.WriteLine("Media menor que Sete");
            else
                Console.WriteLine("Media maior que Sete");

            Console.ReadKey();
        }
    }
}
