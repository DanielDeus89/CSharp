using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            int aCount = 0,
                bCount = 0,
                cCount = 0,
                dCount = 0,
                eCount = 0;

            for (int i=1; i<= 10; i++)
            {
                Console.Write("{0} Enter a letter Grade: ", i);
                grade = char.Parse(Console.ReadLine());

                switch (grade)
                {
                    case 'A':
                    case 'a':
                        ++aCount;
                        break;
                    
                    case 'B':
                    case 'b':
                        ++bCount;
                        break;
                    
                    case 'C':
                    case 'c':
                        ++cCount;
                        break;
                    
                    case 'D':
                    case 'd':
                        ++dCount;
                        break;                    
                    
                    case 'E':
                    case 'e':
                        ++eCount;
                        break;

                    default:
                        Console.WriteLine(
                            "Incorrect letter grade entered. \nGrade not added to Totals.");
                    break;

                }
                Console.WriteLine("\nTotal for each letter are \nA:{0} \nB:{1} \nC:{2} \nD:{3} \nE:{4}", aCount, bCount, cCount, dCount, eCount);
                Console.ReadKey();


            }


        }
    }
}
