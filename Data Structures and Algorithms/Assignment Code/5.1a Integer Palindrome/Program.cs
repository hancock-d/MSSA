namespace _5._1a_Integer_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{

                int x;
                Console.Write("Please enter a number to see if it's a palindrome: ");
                int.TryParse(Console.ReadLine(), out x);
                //int x = int.Parse(Console.ReadLine());

                if (x < 0 || x % 10 == 0) // if x%10=0, then the number ends in a 0. The number cannot start with 0, so it cannot end in 0
                {
                    Console.WriteLine("Number is negative or starts or ends with a 0-not a palindome");
                }
                else
                {
                    int original = x; //assigning original to the user input to store it for comparison while x can be manipulated
                    int xReversed = 0; //xRev starts at 0

                    while (x > 0)
                    {
                        int digit = x % 10; //%10 gets to the last digit of x by dividing by 10 and looking at the remainder, then assigns the remainder to digit
                        xReversed = xReversed * 10 + digit; //rebuilds xRev by moving digit to tens then adding the ones/single digit
                        x = x / 10; //divides x / 10 to cut off the "remainder"--or last digit--and remaining number is x
                    }

                    if (original == xReversed)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                //}
                Console.ReadKey();
            }
        }
    }
}
