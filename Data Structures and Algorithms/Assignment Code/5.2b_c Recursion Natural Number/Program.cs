namespace _5._2b_Recursion_Natural_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintNaturals(10);
            Console.WriteLine();
            PrintBackwards(10);
        }

        static void PrintNaturals(int n)
        {
            if (n == 1)
            {
                Console.Write(n + " ");
                return; //returns to previous method call (PN(2...and so on)), which created a large backlog of function calls on n, then will "unwind" and print them out
            }
            PrintNaturals(n - 1); //goes to the next? original? function call before writing n, then writes n on the way out
            Console.Write(n + " ");

        }

        static void PrintBackwards(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            Console.Write(n + " "); //writes n before going to the next function call
            PrintBackwards(n - 1);
        }
    }

}



/* printnaturals(n)
 * if n ==1
 * print n
 * return
 * 
 * 
 * printnaturals(n-1)
 * print n
 * 
 * 
 * for i=1->=n, i++
 * print i
 * 
 * 
 * int i=1
 * while i <=n
 * print i
 * i++ 
 * 
 * 
 */
