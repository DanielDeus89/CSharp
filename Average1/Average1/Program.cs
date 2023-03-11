using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, gradeCounter, gradeValue, avarege;

            total = 0;
            gradeCounter = 1;

            while(gradeCounter <= 10)
            {
                Console.Write("Enter integer Grade: ");
                gradeValue = Int32.Parse(Console.ReadLine());

                total += gradeValue;

                gradeCounter += 1;
            }
            avarege = total / 10;

            Console.WriteLine("\nClass avarege {0}", avarege);
        }
    }
}
