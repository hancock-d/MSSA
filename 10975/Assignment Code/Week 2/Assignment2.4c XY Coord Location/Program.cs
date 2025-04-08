using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._4c_XY_Coord_Location
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char choice = 'y';

            while (choice == 'y' || choice == 'Y') 
            {

                //-------------Determine which quadrant coordinate lies

                Console.Write("Input the value for X: ");
                int xCoord = int.Parse(Console.ReadLine());
                Console.Write("Input the value for Y: ");
                int yCoord = int.Parse(Console.ReadLine());

                //            Console.WriteLine($"The coordinate point ({x},{y} lies in the {quadrant} quadrant.");

                if (xCoord > 0 && yCoord > 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) lies in the First quadrant");
                }
                else if (xCoord < 0 && yCoord > 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) lies in the Second quadrant");
                }
                else if (xCoord < 0 && yCoord < 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) lies in the Third quadrant");
                }
                else if (xCoord > 0 && yCoord < 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) lies in the Fourth quadrant");
                }
                else if (xCoord == 0 && yCoord != 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) is on the Y-axis");
                }
                else if (xCoord != 0 && yCoord == 0)
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) is on the X-axis");
                }
                else
                {
                    Console.WriteLine($"Your point ({xCoord},{yCoord}) is at the center");
                }

            Console.WriteLine("\nDo another? y/n");
            choice = char.Parse(Console.ReadLine());
            Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


/*
 * Get X coordinate, get Y coordinate 
 * Identify quadrants
 *      1: ++
 *      2: -+
 *      3: --
 *      4: +-
 *      5: x axis
 *      6: y axis
 *      7: Center
 * 
 * method: compare x y coords
 * method: find quadrant
 * 
 * 
 */
