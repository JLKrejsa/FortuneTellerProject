using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JK_FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Madame Jen's!");
            Console.WriteLine("The answer to the mysteries of your future awaits.");
            Console.WriteLine("Come closer.");
            Console.WriteLine("Ok, that's close enough.");
            Console.WriteLine("I need to gather some information, then your future will be revealed.");
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("Type Help for a definition of ROYGBIV");

            string faveColor = Console.ReadLine();
            bool help = true;
            if (help)
            {
                Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Indigo, and Violet.");
                Console.WriteLine("These are the colors of the rainbow");

                Console.WriteLine("Of those choices, what is your favorite color?");
                string faveColor2 = Console.ReadLine();
            }

            //Console.WriteLine((name ) + (lastName));

            Console.WriteLine("How many siblings do you have?");
            int sibs = int.Parse(Console.ReadLine());
        }
    }
}
