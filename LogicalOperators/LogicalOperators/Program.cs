using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional AND (&&)" +
                "\nfalse && false:\t" + (false && false) +
                "\nfalse && true:\t" + (false && true) +
                "\ntrue && false:\t" + (true && false) +
                "\ntrue && true:\t" + (true && true)); 
            
            
            Console.WriteLine("\n\nConditional OR (||)" +
                "\nfalse || false:\t" + (false || false) +
                "\nfalse || true:\t" + (false || true) +
                "\ntrue || false:\t" + (true || false) +
                "\ntrue || true:\t" + (true || true));     
            

            Console.WriteLine("\n\nLogical and (&)" +
                "\nfalse & false:\t" + (false & false) +
                "\nfalse & true:\t" + (false & true) +
                "\ntrue & false:\t" + (true & false) +
                "\ntrue & true:\t" + (true & true));         
            

            Console.WriteLine("\n\nLogical and (|)" +
                "\nfalse | false:\t" + (false | false) +
                "\nfalse | true:\t" + (false | true) +
                "\ntrue | false:\t" + (true | false) +
                "\ntrue | true:\t" + (true | true));


            Console.WriteLine("\n\nLogical exclusive OR (^)" +
                "\nfalse ^ false:\t" + (false ^ false) +
                "\nfalse ^ true:\t" + (false ^ true) +
                "\ntrue ^ false:\t" + (true ^ false) +
                "\ntrue ^ true:\t" + (true ^ true));


            Console.WriteLine("\n\nLogical NOT (!)" +
                "\n!false:\t" + (!false) +
                "\n!true:\t" + (!true));
        }
    }
}
