using System;

namespace AgeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameFirstPerson, nameSecondPerson;
            int firstPersonAge, secondPersonAge;

            Console.Write("Please enter the first name: ");
            nameFirstPerson = Console.ReadLine();



            Console.Write("Enter {0}'s age: ", nameFirstPerson);
            firstPersonAge = Int32.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the second name: ");
            nameSecondPerson = Console.ReadLine();

            Console.Write("Enter {0}'s age: ", nameSecondPerson);
            secondPersonAge = Int32.Parse(Console.ReadLine());

            if (firstPersonAge > secondPersonAge)
            {
                Console.WriteLine("\n\n{0} is older than {1}, with an age of {2}.", nameFirstPerson, nameSecondPerson, firstPersonAge);
            }
            else if (firstPersonAge < secondPersonAge)
            {
                Console.WriteLine("\n\n{0} is older than {1}, with an age of {2}.", nameSecondPerson, nameFirstPerson, secondPersonAge);
            }
            else
            {
                Console.WriteLine("\n\n{0} is the same age as {1}.", nameSecondPerson, nameFirstPerson);
            }

            Console.ReadKey();
        }
    }
}
