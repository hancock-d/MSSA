namespace Mod2Recursion4Factorial
{
    internal class Program
    {
        //FACTORIAL by ITERATION then RECURSION

        // 4! = 4 * 3 * 2 * 1 == 4 * 3!
        // 3! = 3 * 2 * 1
        // n! = (n-1)! * n
        static long Factorial_Iteration(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static long Factorial_Recursion(int n)
        {
            if (n == 1) // base/terminating condition
                return 1;
            else
            {
                return Factorial_Recursion(n - 1) * n;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial by Iteration: {Factorial_Iteration(5)}");
            Console.WriteLine($"Factorial by Recursion: {Factorial_Recursion(5)}");
            
            Console.ReadKey();
        }
    }
}
