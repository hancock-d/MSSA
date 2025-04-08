using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._4b_LargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------Find the largest of 3 numbers
            Console.WriteLine("Input 3 numbers to compare:");
            Console.Write("Number 1: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write("Number 3: ");
            int num6 = int.Parse(Console.ReadLine());

//            int num1 = 25;
//            int num2 = 63;
//            int num3 = 10;

            int largest = FindLargest(num4, num5, num6);

            Console.WriteLine($"The largest number you provided is {largest}");


            Console.ReadKey();
        }

        public static int FindLargest(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                throw new Exception("All numbers are equal");
            }
            else if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}


/*Get 3 numbers from user
 * Convert the input from string to int
 * Compare the numbers using IF/ELSE IF/ELSE--practice creating a new function and passing to it
 *      a > b and a > c, a largest
 *      b > a and b > c, b largest
 *      c > a and c > b, c largest
 * assign answer by Invoking method
 * Output largest number
 * 
 * */

