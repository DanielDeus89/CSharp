using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Please enter first Integer:");
            number1 = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter second Integer:");
            number2 = Int32.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("{0} == {1}", number1, number2);
            }
            else if (number1 != number2)
            {
                Console.WriteLine("{0} != {1}", number1, number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("{0} < {1}", number1, number2);
            }
            else if (number1 > number2)
            {
                Console.WriteLine("{0} > {1}", number1, number2);
            }
            else if (number1 <= number2)
            {
                Console.WriteLine("{0} <= {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} >= {1}", number1, number2);
            }



            Console.ReadKey();
        }
    }
}
