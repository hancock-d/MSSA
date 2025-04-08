using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Challenge_Temps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {

                //------------Temp comfortability message

                Console.Write("What's the current temperature outside in Fahrenheit? ");
                int temp = int.Parse(Console.ReadLine());

                if (temp < 0)
                {
                    Console.WriteLine("That's too cold, nobody likes that");
                }
                else if (temp >= 0 && temp <= 10)
                {
                    Console.WriteLine("It's freezing");
                }
                else if (temp > 10 && temp <= 20)
                {
                    Console.WriteLine("It's very cold");
                }
                else if (temp > 20 && temp <= 35)
                {
                    Console.WriteLine("It's cold");
                }
                else if (temp > 35 && temp <= 50)
                {
                    Console.WriteLine("That feels normal");
                }
                else if (temp > 50 && temp <= 65)
                {
                    Console.WriteLine("It's warm");
                }
                else if (temp > 65 && temp <= 80)
                {
                    Console.WriteLine("It's hot");
                }
                else
                {
                    Console.WriteLine("It's too hot, nobody likes that");
                }

            Console.WriteLine("\nDo another? y/n");
            choice = char.Parse(Console.ReadLine());
            Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}

/* Get user input
 * If/else ifs
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */