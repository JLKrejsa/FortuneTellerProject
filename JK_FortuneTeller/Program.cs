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
            int age = Console.ReadLine();

            Console.WriteLine("What month were you born?");
            int month = Console.ReadLine();

            Console.WriteLine("What is your favority ROYGBIV color?");
            Console.WriteLine("Type Help if you don't know what ROYGBIV is");



            //Console.WriteLine((name ) + (lastName));

        }
    }
}
