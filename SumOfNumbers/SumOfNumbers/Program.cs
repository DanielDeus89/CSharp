using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a sequence of numbers separated by commas: ");
                string inputNumber = Console.ReadLine();

                if (inputNumber == "0")
                {
                    Console.WriteLine("Program ended");
                    break;
                }

                string[] numbers = inputNumber.Split(' ');
                int count = numbers.Length;

                for (int i = 0; i < count; i++)
                {
                    sum += Int32.Parse(numbers[i]);
                }
                Console.WriteLine("The sum is: {0:0.00}", sum);

            }

            Console.ReadKey();
        }
    }
}