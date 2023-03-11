using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passes = 0,
                failures = 0,
                student = 1,
                result;

            while(student <= 10)
            {
                Console.Write("{0}: Enter Resulta (1=Pass, 2=Fail): ", student);
                result = Int32.Parse(Console.ReadLine());

                if (result == 1)
                {
                    passes += 1;
                }
                else
                {
                    failures += 1;
                }
                student += 1;
            }
            Console.WriteLine();
            Console.WriteLine("Passed {0}:", passes);
            Console.WriteLine("Failed {0}:", failures);

            Console.ReadKey();
        }
    }
}
