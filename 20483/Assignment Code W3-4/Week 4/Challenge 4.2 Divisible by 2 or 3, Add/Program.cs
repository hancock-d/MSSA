namespace _4._2_Challenge_Divisible_by_2_or_3__Add
{
    internal class Program
    {
        // If num is divisible by 2 or 3, multiply them
        // Otherwise, add them
        static int Divisibleby2or3(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)
            {
                return num1 * num2;
            }
            else
            {
                return num1 + num2;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"15, 30: {Divisibleby2or3(15, 30)}"); //true, expecting 450
            Console.WriteLine($"2, 90: {Divisibleby2or3(2, 90)}"); //true, expecting 180
            Console.WriteLine($"7, 12: {Divisibleby2or3(7, 12)}"); //false, expecting 19

            Console.ReadKey();
        }
    }
}
