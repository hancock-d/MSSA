using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3ForLoopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers");

            //for (initialization, evaluate; increment)
            for (int i = 1; i <= 10; i++) //i++ or i = i+1
            {
                Console.WriteLine(i); //will print value of i, then increment it, and go check again

            }
            //print even numbers from 2 - 50 using for loop
            for (int i = 2; i <= 50; i = i + 2)
            {
                Console.Write(i + " "); //prints all numbers on same line
            }
            Console.WriteLine(); //adds a new line then prints the numbers on that same line in the next for look
            for (int i = 2; i <= 50; i++)
            {
                if (i % 2 == 0) { Console.Write(i + " "); } //another way to do it
            }
            Console.WriteLine(); //new line between for loops
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            // 5!=5*4*3*2*1 = 5 factorial
            int num = 5; //hard coded in, can get number from user
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i; //multiply factorial * i as long as num <= 5
                //factorial = 1*1=1
                //factorial = 1*2=2
                //factorial = 2*3=6
                //factorial = 6*4=24
                //factorial = 24*5=120
                Console.WriteLine(factorial);
                Console.ReadKey();
            }
            int j = 1; //initialization
            while(j<=20) //condition
            {
                Console.WriteLine(j); //write j
                j++; //increment
            }
            Console.ReadKey();
        }
    }
}
