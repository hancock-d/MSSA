namespace Challenge_3._1_Palindrome
{
    internal class Program
    {
        //----------------------Palindrome
        public static bool IsPalindrome(string input)
        {

            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != chars[chars.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please type in your word to see if it's a palindrome: ");
            string input = Console.ReadLine().ToLower();

            bool result = IsPalindrome(input);

            if (result==true)
            {
                Console.WriteLine($"\nYes, {input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\nNo, {input} is not a palindrome.");
            }
            Console.ReadKey();
        }
    }
}



