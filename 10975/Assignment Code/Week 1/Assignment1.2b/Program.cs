using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2b
{
    internal class Program
    {
        //Find the sum of the first 10 natural numbers, for loop
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see the first 10 natural numbers"); //put this outside for loop so it won't be repeated


            for (int i = 1; i <= 10; i++) //for integer i, while i <= 10, add i + 1
            {
                Console.Write(i + " "); //print value of i, then return to top of loop until 10 is reached
            }

            Console.WriteLine();
            Console.WriteLine("Now let's add them together. How high would you like to go?");
            int max = Int32.Parse(Console.ReadLine()); //previously hard coded the max at 10, but wanted to experiment
            int count = 0; //declaring start point for count as 0. When I started at 1, it added an extra +1 to the count
            for (int num = 0; num <= max; num++) //count will grow by 1 as long as num <11, then add 1 to num
            {
                count = count + num; //count will grow by num, starting at 0
            }
            Console.WriteLine($"The sum is {count}."); //put this outside the for loop so it won't be repreated
            Console.WriteLine("Hello");

            Console.ReadKey();
        }
    }
}
