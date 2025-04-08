using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Assignment1._4aAlternate
{
    internal class Program
    {
        static void Compare(Point point1, Point point2) //writing Compare method
        {
            if (point1.x > point2.x)
            {
                Console.WriteLine("Point 1 is to the right of point 2");
            }
            else if(point1.x < point2.x)
            {
                Console.WriteLine("Point 1 is to the left of point 2");
            }
            else
            {
                Console.WriteLine("Point 1 and point 2 are on the same X axis");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Provide point 1 X coord");
            int.TryParse(Console.ReadLine(), out int point1x);  //same as declaring point1x ahead of time
            Console.WriteLine("Provide point 1 Y coord");
            int.TryParse(Console.ReadLine(), out int point1y);

            Console.WriteLine("\nProvide point 2 X coord");
            int.TryParse(Console.ReadLine(), out int point2x);
            Console.WriteLine("Provide point 2 Y coord");
            int.TryParse(Console.ReadLine(), out int point2y);

            Point point1 = new Point(point1x, point1y); //creates a new Point (point1) from the struct with user input
            Point point2 = new Point(point2x, point2y);

            Compare(point1, point2); //calling Compare method, passing point1, point2

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
