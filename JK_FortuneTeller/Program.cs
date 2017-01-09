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
            
            Console.WriteLine("What month were you born? Use numerical value.");
            int month = int.Parse(Console.ReadLine());
            
            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("Type Help for a definition of ROYGBIV");

            string answer = Console.ReadLine();

            if (answer == "help")
            {
                Console.WriteLine("red, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("What color do you choose?");
            }
            
            Console.WriteLine("How many siblings do you have?");
            int sibs = int.Parse(Console.ReadLine());
        
           
                if (age % 2 == 0)
                {
                    Console.WriteLine("You will retire in 20 years");
                }
                else
                {
                    Console.WriteLine("You will retire in 40 years");
                }

                if (month == 1 - 4)
                {
                    Console.WriteLine("$4 million");
                }
                else if (month == 5 - 8)
                {
                    Console.WriteLine("$500,000");
                }
                else if (month == 9 - 12)
                {
                    Console.WriteLine("$750,000");
                }

                else
                {
                    Console.WriteLine("$0");
                }

            switch (answer)

            {
                case "red":
                    Console.WriteLine("a Mustang");
                    break;
                case "orange":
                    Console.WriteLine("a Cruiser bike");
                    break;
                case "yellow":
                    Console.WriteLine("a Subaru");
                    break;
                case "green":
                    Console.WriteLine("a Prius");
                    break;
                case "blue":
                    Console.WriteLine("a yacht");
                    break;
                case "indigo":
                    Console.WriteLine("a private jet");
                    break;
                case "violet":
                    Console.WriteLine("a convertible");
                    break;
            }

            switch (sibs)
            {
                case 0:
                    Console.WriteLine("A cabin in the Smoky Mountains");
                    break;
                case 1:
                    Console.WriteLine("A beach house at Venice Beach");
                    break;
                case 2:
                    Console.WriteLine("A boat house in Seattle");
                    break;
                case 3:
                    Console.WriteLine("A beach house in Key West");
                    break;
                case 4 - 100:
                    Console.WriteLine("A ranch in California");
                    break;
                default:
                    Console.WriteLine("A mobile home in Kansas");
                    break;
            }

            //Console.WriteLine("name" + "lastName" + "you will retire at " + "age" + "with" + "month" + "in the bank" + "sibs" = answer);

                    //end of code
            }
     }
}
            
            


          
