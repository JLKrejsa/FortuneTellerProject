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
            
            
            Console.WriteLine("What is your favorite ROYGBIV color?");
            Console.WriteLine("Type Help for a definition of ROYGBIV");

            string answer = Console.ReadLine();

            if (answer == "help")
            {
                Console.WriteLine("red, orange, yellow, green, blue, indigo, violet");
                Console.WriteLine("What color do you choose?");
            }
            
            Console.WriteLine("How many siblings do you have?");
            

            string retire;

                if (age % 2 == 0)
                {
                    retire = "20 years";
                }
                else
                {
                    retire = "40 years";
                }
            
                int month = int.Parse(Console.ReadLine());
                float money;
                if (month >= 1 && month <= 4)
                {
                    money = 300000f;
                }
                else if (month >= 5 &&  month <= 8)
                {
                    money = 400000f;
                }
                else if (month >=  9 && month <= 12)
                {
                    money = 500000f;
                }

                else
                {
                    money= 0.0f;
                }

            
            string toTravel;

            switch (answer)
            {
                case "red":
                    toTravel = "a Mustang";
                    break;
                case "orange":
                    toTravel = "a Cruiser bike";
                    break;
                case "yellow":
                    toTravel = "a Subaru";
                    break;
                case "green":
                    toTravel = "a Prius";
                    break;
                case "blue":
                    toTravel = "a yacht";
                    break;
                case "indigo":
                    toTravel = "a private jet";
                    break;
                case "violet":
                    toTravel = "a convertible";
                    break;
            }
            int sibs = int.Parse(Console.ReadLine());
            string vacationHome;
            switch (sibs)
            {
                case 0:
                    vacationHome ="A cabin in the Smoky Mountains";
                    break;
                case 1:
                    vacationHome = "A beach house at Venice Beach";
                    break;
                case 2:
                    vacationHome = "A boat house in Seattle";
                    break;
                case 3:
                    vacationHome = "A beach house in Key West";
                    break;
                case 4 - 100:
                    vacationHome = "A ranch in California";
                    break;
                default:
                    vacationHome = "A mobile home in Kansas";
                    break;
            }

            Console.WriteLine("Your future...");
            Console.WriteLine(string.Concat(name," ",lastName, " "," will retire in ",retire, " "," with $", money," ", "in the bank","with ", vacationHome, " and a ", toTravel));
            

                    //end of code
            }
     }
}
//   Console.WriteLine("\n\n" + firstName + " " + lastName + " will retire in " + retireYears + " with $" + moneyInBank + " in the bank,\na vacation home in " + vacationHome + ", and " + transport + "."); 




