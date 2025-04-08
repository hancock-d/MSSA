namespace Mod2Recursion3SumDigits
{
    internal class Program
    {
        // n=5 sum=1+2+3+4+5==sum(4)+5
        // n=4 sum=1+2+3+4
        // sum(7)=sum(6)+7
        // sum(n)=sum(n-1)+n
        // FINDING SUM OF ALL NUMBERS IN THE SERIES FROM 1 to n

        static int Sum_Recursion(int n)
        {
            if(n==0) return 0; // just leave the function quickly because this math will provide results immediately
            if(n==1) return 1;
            return Sum_Recursion(n - 1) + n; //will be returning a value back and adding that result to the previous(?) calculation
            //How does it know when to stop? Is it because the stack eventually empties out after it reaches the value of n?

        }

        // do it while returning a value
        static int Sum_Iteration(int n)
        {
            int sum = 0;
            int i = 1;
            while (i <= n)
            {
                sum = sum + i;
                i++;
            }
            return sum; //re-declaring sum from 0 to sum+i?
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum by iteration: {Sum_Iteration(5)}");
            Console.WriteLine($"Sum by recursion: {Sum_Recursion(5)}");


            Console.ReadKey();
        }
    }
}
