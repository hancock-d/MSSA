using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3a
{
    internal class Program
    {
        static void areaOfTriangle()
        {
            Console.WriteLine("Provide the base of the triangle:");
            float base1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Provide the height of the triangle:");
            float height1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the triangle is: {(base1 / 2) * height1}.");
        }
        static void areaOfSquare()
        {
            Console.WriteLine("Provide the side of the square");
            int side1 = int.Parse(Console.ReadLine()); //initializing side1
            Console.WriteLine($"The area of the square is: {(side1 * side1)}");
        }

        static void areaOfParallelogram()
        {
            Console.WriteLine("Please provide the two sides of the rectangle");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The area of the rectangle is: {(side1 * side2)}");
        }

        static void Main(string[] args)
        //Give choice to select shape 1-Triangle, 2-Square, 3-Rectangle
        {
            string selection; //declaring their option pick for 1-3, must be type string

            char choice = 'y'; //initializing choice for play again or not

            while (choice == 'y' || choice == 'Y') //starting while loop if they chose Yes will restart, will end if not
            {
                Console.WriteLine("Choose which object you want to take the area of");
                Console.WriteLine("1. Triangle, 2. Square, or 3. Rectangle");
                selection = Console.ReadLine(); //setting their pick into selection

                switch (selection) //starting the switch algorithm
                {
                    case "1": //Triangle
                        areaOfTriangle(); //calling the function, not passing anything into it cause it'll happen after being called
                        break;
                    case "2": //Square
                        areaOfSquare();
                        break;
                    case "3": //Rectangle
                        areaOfParallelogram();
                        break;
                }
                Console.WriteLine("Do you want to do another? Y, N");
                choice = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Press any key to exit");
            }
            Console.ReadKey();
        }
    }
}
