using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();

            Console.WriteLine("Enter X and Y coordinates for P1:");
            Console.Write("X: ");
            P1.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            P1.Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter X and Y coordinates for P2:");
            Console.Write("X: ");
            P2.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            P2.Y = int.Parse(Console.ReadLine());

            Console.WriteLine($"P1: ({P1.X}, {P1.Y})");
            Console.WriteLine($"P2: ({P2.X}, {P2.Y})");

            if(P1.X > P2.X)
            {
                Console.WriteLine("\nPoint 1 is to the right of Point 2");
            }
            else if (P1.X < P2.X)
            {
                Console.WriteLine("\nPoint 1 is to the left of Point 2");
            }
            else
            {
                Console.WriteLine("\nPoint 1 and Point 2 are on the same X axis");
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
