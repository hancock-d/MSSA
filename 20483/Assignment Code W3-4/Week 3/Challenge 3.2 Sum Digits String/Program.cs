namespace Challenge_3._2_Sum_Digits_String
{
    internal class Program
    {
        //Method to return sum of digits found in a string
        public static int SumDigitsString(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i]; //access char at position i in the string

                if (char.IsDigit(c)) //intellisense suggestion
                {
                    int digit = int.Parse(c.ToString()); //converting c to a string because parse wants a string type as input
                    sum += digit; //adding value of digit to sum
                }
            }
        return sum;
        }
        static void Main(string[] args)
        {
            string test1 = "1q2w3e";
            string test2 = "l0r3m.1p5um";
            string test3 = "";

            Console.WriteLine($"{test1} \t\t--> Total of digits = {SumDigitsString(test1)}");
            Console.WriteLine($"{test2} \t--> Total of digits = {SumDigitsString(test2)}");
            Console.WriteLine($"{test3} \t\t--> Total of digits - {SumDigitsString(test3)}");


            Console.ReadKey();
        }
    }

}


/*
 * Initialize sum variable to hold total of all digits in the string
 * 
 * iterate over each character in the string and see if it's a digit--use an array?
 *      foreach char in string
 *      is char between 0 and 9? char.IsDigit?
 *          If yes
 *              convert to int
 *              add to sum
 *      return sum
 *          
 * 
 * 
 * 
 * 
 */