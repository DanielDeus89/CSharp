using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, gradeCounter, gradeValue;

            double average;

            total = 0;
            gradeCounter = 0;

            Console.Write("Enter Integer Grade, -1 to Quit: ");
            gradeValue = Int32.Parse(Console.ReadLine());

            while (gradeValue != -1)
            {
                total += gradeValue;
                gradeCounter += 1;

                Console.Write("Enter Integer Grade, -1 to Quit: ");
                gradeValue = Int32.Parse(Console.ReadLine());
            }
            if(gradeCounter != 0)
            {
                average = (double)total / gradeCounter;
                Console.WriteLine("\nClass average {0}", average);
            }
            else
            {
                Console.WriteLine("No Grades were entered.");
            }

            Console.ReadKey();
        }
    }
}
