using System.Runtime.Intrinsics.Arm;

namespace _5._3b_Climbing_Staircase
{
    internal class Program
    {
        static int ClimbStairs(int n)
        {
            //a = #ways to reach previous step (i-2)
            //b = #ways to reach current step (i-1)
            int a = 1;// base case--1 way to reach step 0
            int b = 1; //base case--1 way to reach step 1


            //starting loop at step 2 because 0 and 1 are already done
            for (int i = 2; i <= n; i++) //n == total # steps in staircase; i==current step
            {

                int temp = a + b; //compute next step
                a = b; //move forward in Fibonacci sequence--(move b i-1 to a i-2)
                b = temp; //move temp (new ways for i) to b (i-1)--B now store step count at step i


            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(0));

            Console.WriteLine(ClimbStairs(1));
            Console.WriteLine(ClimbStairs(2));
            Console.WriteLine(ClimbStairs(3));

            Console.WriteLine(ClimbStairs(4));
            Console.WriteLine(ClimbStairs(5));
            Console.WriteLine(ClimbStairs(6));
            Console.WriteLine(ClimbStairs(7));
            Console.WriteLine(ClimbStairs(8));



        }
    }
}


//LOOK AT FIBONACCI DEMO