namespace Mod3FibonacciSeries_Dave
{
    internal class Program
    {
        //-------------ITERATION APPROACH--------------
        //return the number/result (int) and print the series
        // 0,1,1,2,3,5,8,13...
        // Linear time complexity O(n)
        static int Fibonacci_Iteration(int n)  //print the series
        {
            int first = 0, second = 1, result = 0; //establishing pointers

            if (n == 0) //if someone passes n = 0, don't print anything, just return 0
            {
                return 0; //where is this 0 going to? --the caller of hte function
            }
            if (n == 1)
            {
                Console.Write(0);
                return 1; //result
            }
            Console.Write("0" + ",1,"); //if the above 2 conditions are not satisfied, will print this before starting next series
            for (int i = 2; i < n; i++)
            {
                result = first + second;
                Console.Write(result + ",");
                first = second; //shifting your pointers right
                second = result;  //replacing first by second, replacing second by result
            }
            return result;
        }

        //------------PURE RECURSIVE APPROACH--not optimal, not linearly efficient--think of the fibonacci tree--------------
        // fib(2) = fib(1) + fib(0)
        // fib(8) = fib(7) + fib(6)
        //          fib(7) = fib(6) + fib(5)
        //          fib(6) = fib(5) + fib(4)

        static int Fibonacci_Recursion(int n)
        {
            if (n <= 1) return n;
            return Fibonacci_Recursion(n - 1) + Fibonacci_Recursion(n - 2);
        }

        // --------------RECURSION + DYNAMIC PROGRAMMING--------------
        // use an array, but declare the array outside of the function so it's not re-used

        static Nullable<long>[] sequence = new Nullable<long>[100]; //value types can hold null values-- " is short form for nullable

        static long? Fib_RecDP(int n) //? because it's a nullable type
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return sequence[n] = Fib_RecDP(n - 1) + Fib_RecDP(n - 2);
        }

        //------------DYNAMIC PROGRAMMING DP APPROACH--------------
        static int[] Fib_DP(int n)
        {
            int[] series = new int[n + 1];
            series[0] = 0;
            series[1] = 1;
            for (int i = 2; i < n; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }
            return series;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci by Iteration");
            Fibonacci_Iteration(8); // print first 8 terms
            Console.WriteLine();

            Console.WriteLine("Fibonacci by Recursion + DP");
            Fib_RecDP(8);
            // Print the series from Fib_RecDP
            foreach (var i in sequence)
            {   //using hasvalue because if it's null, I don't want it to print anything
                if (i.HasValue)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\nFibonacci by DP");
            var results = Fib_DP(8);
            foreach (var i in results)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
