using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favColor;
            char choice = 'y'; //initializing choice as y

            while (choice == 'y' || choice == 'Y') //evaluating choice to be equal to y or Y
            {
                Console.WriteLine("Enter your favorite color from Yellow, Green, Red, Blue");
                favColor = Console.ReadLine();

                switch (favColor.ToLower()) //ToLower is a function on the string, forces their input to lower case
                {
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nice choice!");
                        break; //break from the case
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nice choice!");
                        break; //break from the case
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nice choice!");
                        break; //break from the case
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Nice choice!");
                        break; //break from the case
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("No such color");
                        break;


                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to play again? (y/Y, n/N)");
                choice = char.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
