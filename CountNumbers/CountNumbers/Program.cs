using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int count = 0;
            int sum = 0;
            int avg = 0;

            while (true)
            {

               
                Console.Write("Enter an Integer Number: ");
                number = Int32.Parse(Console.ReadLine());

                if (number == -1)
                {
                    break;
                }
                count++;
                sum += number;


            }
            avg = sum / count;
            
            Console.WriteLine(count);
            Console.WriteLine(sum);
            Console.WriteLine(avg);


            Console.ReadKey();

        }
    }
}
