using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Week 1 Day 1 Assignments
            //Store and print personal details of a person
            string name;
            string location;
            float age;

            Console.WriteLine("Hello, I'd like to ask a few questions about you.");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ". What state do you live in?");
            location = Console.ReadLine();
            Console.WriteLine("I see that you live in " + location + ". How old are you?");
            age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("You're " + age + " years old? You must be very wise.");
            
            //Print sum of 2 numbers, get input from user
            int num1, num2;

            Console.WriteLine("Let's move onto our next project. I'm going to ask you for two numbers and I will add them together.");
            Console.WriteLine("What's your first number?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your second number?");
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + result);

            //Print quotient and remainder of a division problem, get input from user
            int num3, num4;

            Console.WriteLine("We're going to do one more thing. I'm going to divide two new numbers.");
            Console.WriteLine("What's your first number?");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your second number?");
            num4 = Convert.ToInt32(Console.ReadLine());

            int quotient = num3 / num4;
            int remainder = num3 % num4;
            Console.WriteLine(num3 + " / " + num4 + " = " + quotient + "." + remainder);

            Console.ReadKey();
        }
    }
}
