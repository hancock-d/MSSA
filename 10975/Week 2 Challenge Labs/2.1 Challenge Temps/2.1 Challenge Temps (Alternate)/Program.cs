using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Challenge_Temps
{
    internal class Temps2
    {
        static void Main(string[] args)
        {
            // Prompt user for temperature
            Console.Write("Enter the temperature in Fahrenheit: ");
            string input = Console.ReadLine();

            // Parse and validate the input
            if (int.TryParse(input, out int temperature))
            {
                // Determine the temperature state using if conditions
                if (temperature >= 0 && temperature <= 10)
                {
                    Console.WriteLine("Freezing weather");
                }
                else if (temperature >= 11 && temperature <= 20)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if (temperature >= 21 && temperature <= 35)
                {
                    Console.WriteLine("Cold weather");
                }
                else if (temperature >= 36 && temperature <= 50)
                {
                    Console.WriteLine("Normal in Weather");
                }
                else if (temperature >= 51 && temperature <= 65)
                {
                    Console.WriteLine("It's Hot");
                }
                else if (temperature >= 66 && temperature <= 80)
                {
                    Console.WriteLine("It's Very Hot");
                }
                else
                {
                    Console.WriteLine("Temperature out of range for classification.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the temperature.");
            }

            Console.ReadKey(); // Wait for user to press a key before closing
        }
    }
}
