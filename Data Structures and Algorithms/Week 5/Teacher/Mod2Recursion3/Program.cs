namespace Mod2Recursion3
{
    internal class Program
    {

        // n=5 sum=1+2+3+4+5==sum(4)+5
        // n=4 sum=1+2+3+4
        // sum(7)=sum(6)+7
        //sum(n)=sum(n-1)+n
        // finding sum of all numbers in the series from 1 to n


        static int Sum_Recursion(int n)
        {
            if(n==0) return 0;
            if(n==1) return 1;
            return Sum_Recursion(n - 1) + n;
        }
        static int Sum_Iteration(int n)
        {
            int sum = 0;
            int i = 1;
            while(i<=n)
            {
                sum=sum+i;
                i++;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum by iteration :{Sum_Iteration(5)}");
            Console.WriteLine($"Sum by recursion :{Sum_Recursion(5)}");
            Console.ReadKey();



        }
    }
}
