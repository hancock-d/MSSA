namespace _5._1b_Sum_Individual_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out x);
            //int x = int.Parse(Console.ReadLine());
            //int x = 1231;

            //int result = CalculateSum(x);
            //Console.WriteLine($"Sum of digits is {result}");
            Console.WriteLine($"The sum of digits is: {CalculateSum(x)}");

            Console.ReadKey();
        }
        public static int CalculateSum(int number)
        {
            int sum = 0; //establishing sum
            while (number > 0)
            {
                //sum = sum + num % 10;
                sum += number % 10; //changing sum so that sum == sum + the last digit of number
                //num = num / 10;
                number /= 10; //chopping off the last digit of number
            }
            return sum;
        }
    }
}
