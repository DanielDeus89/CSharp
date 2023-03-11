using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int counter=1; counter <=10; counter++)
            {
                Console.WriteLine(counter);
            }
            Console.ReadKey();
        }
    }
}
