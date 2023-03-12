using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.Write("Insert an Integer Number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i=0; i<=number; i++)
            {
                sum += i;
            }

            Console.Write("\nthe total is {0}: ", sum);

            Console.ReadKey();
        }
    }
}
