using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';

            while (choice == 'y' || choice == 'Y')
            {
                Console.Write("Would you like to calculate the area for a 1) Circle, or 2) Square? ");
                int decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 1: //Circle
                        Circle circle1 = new Circle(); //Create an instance of Circle
                        Console.WriteLine("Please enter your circle's ID");
                        circle1.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please name your circle");
                        circle1.Name = Console.ReadLine();
                        Console.WriteLine("What color is your circle?");
                        circle1.Color = Console.ReadLine();
                        Console.WriteLine("Enter the radius");
                        circle1.Radius = int.Parse(Console.ReadLine());
                        Console.WriteLine($"The area of the {circle1.Color} Circle ID# {circle1.Id}, name {circle1.Name} is: {circle1.CalculateArea()}");
                        break;
                    case 2: //Square
                        Square square1 = new Square(); //Create an instance of Square
                        Console.WriteLine("Please enter the square's ID:");
                        square1.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please name your square");
                        square1.Name = Console.ReadLine();
                        Console.WriteLine("What color is your square?");
                        square1.Color = Console.ReadLine();
                        Console.WriteLine("Enter the length of the square");
                        square1.Side = decimal.Parse(Console.ReadLine());

                        Console.WriteLine($"The area of your {square1.Color} Square ID# {square1.Id}, name {square1.Name} is: {square1.CalculateArea()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("\nDo another? Y/N");
                choice = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
