namespace Challenge_4._1_If_Number_Contains_3
{
    internal class Program
    {
        static bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                int digit = num % 10; //sets digit to last digit of num by taking the "remainder"
                if (digit == 3)
                {
                    return true; //exits loop
                }
                else
                {
                    num /= 10; //sets num to original num with last digit chopped off
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Number 10503: {IfNumberContains3(10503)}");
            Console.WriteLine($"Number 1050: {IfNumberContains3(1050)}");

        }
    }
}
