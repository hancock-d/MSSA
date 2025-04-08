using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decision; //declaring decision for what they pick
            char choice = 'y'; //initializing choice as y
            float result; //declaring result as a float for future output

            while (choice == 'y' || choice == 'Y') //evaluating choice to be equal to y or Y, if Y, will continue to switch
            {
                Console.WriteLine("Choose an option below to perform a calculation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                decision = Console.ReadLine(); //re-initializing decision to their pick


                //gather their numbers before math starts; initializing num1 num2
                Console.WriteLine("Enter your first number for the formula");
                float num1 = float.Parse(Console.ReadLine()); //assigning their first number as a float number num1
                Console.WriteLine("Enter your second number for the formula");
                float num2 = float.Parse(Console.ReadLine()); //assigning their second number as a float number num2

                switch (decision) //Starting the switch algorithm to reflect their pick
                {
                    case "1": //Addition
                        result = num1 + num2; //processing math
                        Console.WriteLine($"{num1} + {num2} = {result}");  //showing result for num1 + num2
                        break; //break from the case, will go to play again
                    case "2": //Subtraction
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    case "3": //Multiplication
                        result = num1 * num2;
                        Console.WriteLine($"{num1} * {num2} = {result}");
                        break;
                    case "4": //Division
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                        break;
                    default: //if 1-4 aren't selected. How do I terminate it before asking for num1 num2?
                        Console.WriteLine("No such option.");
                        break;
                }
                Console.WriteLine("Do you want to do another calculation? (y/Y, n/N)");
                choice = char.Parse(Console.ReadLine()); //if y/Y, will start back up top. if n/N, will end
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
