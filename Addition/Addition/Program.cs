using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstNumner, secondNumber;

            int number1, number2, sum;

            Console.Write("Please enter the First Integer:");
            firstNumner = Console.ReadLine();

            Console.Write("Please enter the Second Integer:");
            secondNumber = Console.ReadLine();

            number1 = Int32.Parse(firstNumner);
            number2 = Int32.Parse(secondNumber);

            sum = number1 + number2;

            Console.WriteLine("\nThe Sum is {0}.", sum);

            Console.ReadKey();
        }
    }
}
