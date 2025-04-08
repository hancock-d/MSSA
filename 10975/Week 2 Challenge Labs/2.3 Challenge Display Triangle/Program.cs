using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Challenge_Display_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to see: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the triangle: ");
            int width = int.Parse(Console.ReadLine()); //total number rows in triangle
            Console.WriteLine();

            for (int i = 1; i <= width; i++) //i starts at 1, first row. continues while i <= width. i++ incremments i by 1 after each iteration
            {
                for (int j = 1; j <= i; j++) //controls number of numbers printed in each row
                {
                    Console.Write(number); //number should now be in correct position
                }
                Console.WriteLine(); //moves to a new line after the row was written
            }

            Console.WriteLine();

            for (int i = width; i >0; i--) //starting at full width, decreasing by 1
            {
                for (int j = 1; j <= i; j++) //height increases up to row number
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}



/*
 * 
 * Get number from user
 * Get width from user (will determine number of iterations/rows in triangle)
 * 
 * For loop (move rows)
 * for loop (print numbers for each row)
 * 
 * 
 * 
 * number of iterations = width
 */