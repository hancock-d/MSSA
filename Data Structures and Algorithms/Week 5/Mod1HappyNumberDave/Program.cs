namespace Mod1HappyNumberDave
{
    internal class Program
    {

        static bool IsHappy(int n)
        {
            int sum = n;
            HashSet<int> set = new HashSet<int>();
            while (sum != 1)
            {
                if (set.Contains(sum))
                {
                    return false;
                }
                set.Add(sum);
                sum = SumOfDigitsSquared(sum);
            }
            return true;
        }

        static int SumOfDigitsSquared(int n) //int n is the incoming
        {
            int sum = 0, currentDigit = 0;
            while (n > 0)
            {
                currentDigit = n % 10; //Extract last digit
                n = n / 10; //Remove last digit--need to get to next number
                sum += currentDigit * currentDigit; //Square it and add to sum
            }
            return sum;
        }
        static void Main(string[] args)
        {

            // SumOfDigitsSquared(19);  //For debugging

            Console.WriteLine(IsHappy(19)); // Output: true   ---check these
            Console.WriteLine(IsHappy(2));  // Output: false

        }
    }
}
