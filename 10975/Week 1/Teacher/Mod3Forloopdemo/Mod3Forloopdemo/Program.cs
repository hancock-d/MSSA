using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Forloopdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers");

            // for(intilization, evaluate, increment
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
            // print even numbers from 2 till 50
            for(int i=2;i<=50;i=i+2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i=2;i<=50;i++)
            {
                if(i %2==0) { Console.Write(i + " "); }
            }
            // reverse numbers from 10 to 1
            for(int i=10;i>0;i--)
            {
                // complex logic
                Console.WriteLine(i);
            }


            // 5!=5*4*3*2*1
            // 6!=6*5*4*3*2*1
            int num = 5;
            int factorial = 1;
            for(int i=1;i<=num;i++)
            {
                factorial=factorial*i;
                // factorial=1*1=1
                //1*2=2
                //2*3=6
                //6*4=24
                //24*5=120
            }
            int j = 1; // initialization
            while(j<=20) // condition
            {
                Console.WriteLine(j);
                j++; // increment
            }
            Console.ReadKey();
        }
    }
}
