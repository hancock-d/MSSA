using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Showing all even numbers from 1-99");
            // Calling ReturnEvenNumbers Method
            string evenNumbers = ReturnEvenNumbers();
            Console.WriteLine(evenNumbers);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        //Creating ReturnEvenNumbers method
        static string ReturnEvenNumbers()
        {
            //Initialize a StringBuilder instance
            StringBuilder count = new StringBuilder(); //create a StringBuilder object to hold even numbers

            //Loop through even numbers from 2-98
            for (int i = 2; i < 100; i += 2)
            {
                count.Append($"{i} "); //appending count with the new value of i after each iteration
            }
            return count.ToString(); //after for loop finishes, must return the entire string and convert it ToString
        }
    }
}
