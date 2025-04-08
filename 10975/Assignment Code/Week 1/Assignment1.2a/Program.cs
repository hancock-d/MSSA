using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2a
{
    internal class Program
    {
        //Accept 2 integers, see if they're equal
        static void CheckNums(int num1, int num2)
        {
            if (num1 == num2) //starting if-else statement, condition
            {
                Console.WriteLine($"{num1} and {num2} are equal"); //if statement is true, print this
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal"); //else if statement is false, print this
            }
            Console.WriteLine("Press any key to close");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to check if they are equal or not"); //asking for 2 integers
            int num1 = Int32.Parse(Console.ReadLine()); //converting integers from read string to integers
            int num2 = Int32.Parse(Console.ReadLine());
            CheckNums(num1, num2); //run the CheckNums loop with num1 and num2 as the values?

            Console.ReadKey();
        }
    }
}
