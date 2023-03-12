using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sequence of numbers separated by commas: ");
            String input = Console.ReadLine();

            string[] numbers = input.Split(',');
            int sum = 0;
            int count = numbers.Length;

            for (int i = 0; i < count; i++)
            {
                sum += Int32.Parse(numbers[i]);
            }

            double average = (double)sum / count;

            Console.WriteLine("The average is: {0:0.00}", average);

            Console.ReadKey();
        }
    }
}
