using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    internal class Program
    {
        // part 1
        // checking two integers are equal or not
        static string compareInt(int a, int b)
        {
            if(a == b)
            {
                return $"{a} and {b} are equal";
            }
            return $"{a} and {b} are not equal";
        }

        static void sumOfTen()
        {
            int sum = 0;
            string numbers = "";
            Console.WriteLine("The first ten natural numbers are:");

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write($"{i} ");
            }
            
            Console.WriteLine($"\nThe Sum is: {sum}");
        }

        static void calculator(float c, float d)
        {
            bool choice = false;
            int option;
            string[] optionValues = { "Addition", "Subtraction", "Multiplication", "Division" };
            int[] optionKeys = { 1, 2, 3, 4 };

            while (!choice) 
            { 
                Console.WriteLine("Please enter a option from below");

                for (int i = 0; i < optionValues.Length; i++)
                {
                    Console.WriteLine($" {optionKeys[i]} for {optionValues[i]}");
                }

                option = Int32.Parse(Console.ReadLine());

                if (!optionKeys.Contains(option)) 
                {
                    Console.WriteLine("Invalid option\n");
                }
                else
                {
                    choice = true;
                    /*Console.WriteLine($"\nNow enter two numbers to perform {optionValues[option-1]}");
                    float a = float.Parse(Console.ReadLine());
                    float b = float.Parse(Console.ReadLine());*/

                    switch(option)
                    {
                        case 1:
                            Console.WriteLine($"Sum of {c} and {d} is: {c + d}");
                            break;

                        case 2:
                            Console.WriteLine($"Differen between {c} and {d} is: {c - d}");
                            break;

                        case 3:
                            Console.WriteLine($"Multiplication of {c} and {d} is: {c * d}");
                            break;
                        case 4:
                            if (d != 0)
                            {
                                Console.WriteLine($"Division between {c} and {d} is: {c / d}");
                            }
                            else {
                                Console.WriteLine("Invalid! Division by zero is not valid.");
                            }
                            
                            break;
                    }

                }  
            } // while loop ends   
        }

        static void textColor(string color) 
        {
            color = color.ToLower();

            switch (color) 
            {
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Could not find the color. Returning to default, white");
                    break;

            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n----- Problem 1 -----\n");
            char option = 'y';
            while (char.ToLower(option) == 'y')
            {

                Console.WriteLine("Please enter two integers to check if they are equal or not");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                Console.WriteLine(compareInt(a, b));

                Console.WriteLine("\nDo you want to check again? (y/Y) or (n/N)");
                option = Char.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPress any button to continue to problem 2");
            Console.ReadKey();

            // part two
            textColor("cyan");
            Console.WriteLine("\n----- Problem 2 -----\n");
            textColor("white");
            sumOfTen();

            // part three
            textColor("blue");
            Console.WriteLine("\n----- Problem 3 -----\n");
            textColor("white");
            Console.WriteLine("Welcome to my Calculator!\n");
            Console.WriteLine("Please enter two number to perform a arithmatic operation");
            float c = Int32.Parse(Console.ReadLine());
            float d = Int32.Parse(Console.ReadLine());
            char optionThree = 'y';
            while (char.ToLower(optionThree) == 'y') 
            {
                calculator(c, d);
                Console.WriteLine("\nDo you want to play again? (y/Y) or (n/N)");
                optionThree = Char.Parse(Console.ReadLine());
            }
            
            Console.ReadKey();
        }
    }
}
