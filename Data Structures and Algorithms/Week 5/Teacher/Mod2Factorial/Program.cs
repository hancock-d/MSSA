﻿namespace Mod2Factorial
{
    internal class Program
    {
        //4!=4*3*2*1==4 *3!
        // 3!=3*2*1
        //n!=(n-1)! * n
        static long Factorial_Iteration(int n)
        {
            long fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static long Factorial(int n)
        {
            if(n==1)// base 
                return 1;
            return Factorial(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial by iteration : {Factorial_Iteration(4)}");
            Console.WriteLine($"Factorial by recursion : {Factorial(4)}");
            Console.ReadKey();
        }
    }
}
