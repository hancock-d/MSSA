namespace Mod2Recursion2
{
    internal class Program
    {
        static void PrintSquares_Iteration(int n)
        {
            while(n > 0)
            {
                Console.WriteLine(n*n);
                n--;
            }
        }
        static void Square_TailRecursion(int n)
        {
            if(n>0) // base 
            {
                Console.WriteLine(n*n);
                Square_TailRecursion(n - 1);// recursive call
            }
        }
        static void Square_HeadRecursion(int n)
        {
            if(n>0)
            {
                Square_HeadRecursion (n - 1);
                Console.WriteLine(n*n);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Print squares by iteration");
            PrintSquares_Iteration(6);
            Console.WriteLine("Print squares by tail recursion");
            Square_TailRecursion(6);
            Console.WriteLine("Print squares by head recursion");
            Square_HeadRecursion(6);
            Console.ReadKey();
        }
    }
}
