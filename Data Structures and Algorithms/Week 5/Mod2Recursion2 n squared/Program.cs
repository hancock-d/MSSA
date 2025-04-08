namespace Mod2Recursion2_n_squared
{
    internal class Program
    {
        //PRINT SQUARES OF N FROM N TO N>0 (6 TO 1)
        //USING ITERATION WITH WHILE LOOP
        //THEN USING RECURSION
        static void PrintSquares_Iteration(int n) //passing value n
        {
            while(n>0)
            {
                Console.WriteLine(n * n); //print the square
                n--; //go backwards from n to n>0 (1)
            }
        }

        //RECURSIVE method
        static void Square_TailRecursion(int n) //called TailRecursion because the recursive call is at the end of the function, there's not other logic afterwards
        {
            if (n>0) //base condition
            {
                //can allocate k = n*n; but makes an unnecessary variable 
                Console.WriteLine(n * n);
                Square_TailRecursion(n - 1); //recursive call
            }
        }
        static void Square_HeadRecursion(int n) //will REVERSE the order--1 4 9 16 25 36--I don't understand why?
        {
            if (n>0)
            {
                Square_HeadRecursion(n - 1); //something about popping out changing the order
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
