using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3FunctionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static methods can call only static methods directly
            string name;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            DisplayGreeting(name); //calling the method with string parameter
            int num1, num2;
            Console.WriteLine("Enter 2 numbers to add.");
            num1 = Int32.Parse(Console.ReadLine()); //same as using Convert.To but this is better(?) Converting string big of the above line to a 32bit int
            num2 = Int32.Parse(Console.ReadLine());
            int result=AddNumbers(num1, num2);
            Console.WriteLine($"Sum of {num1} and {num2} is {result}");
            Console.ReadKey();
        }
        //function declaration, also contains signature
        static void DisplayGreeting(string nameOfPerson) //list of parameters (nameOfPerson), use comma to add more
        {
            Console.WriteLine("Welcome " + nameOfPerson); //concatenation
            Console.WriteLine($"Hi {nameOfPerson}, how are you?"); //interpolation
        }
        //declaring another function
        static int AddNumbers(int i, int j) //can also use data type float
        {
            return i + j;
        }
    }
}
