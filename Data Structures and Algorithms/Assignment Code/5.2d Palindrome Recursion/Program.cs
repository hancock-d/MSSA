namespace _5._2d_Palindrome_Recursion
{
    internal class Program
    {
        //public static bool IsPalindrome(string text)
        //{
        //    //Base case: if length of text is 0 or 1, true
        //    if (text.Length == 0 || text.Length == 1) //shorten this up <=1
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        //Check if first and last chars are ==
        //        if (text[0] != text[text.Length - 1])
        //            return false;
        //        else
        //        {
        //            //Recursive Call: check the substring without the first and last characters
        //            return IsPalindrome(text.Substring(1, text.Length - 2));                }
        //    }
        //}

        public static bool IsPalindrome(string text, int pointLeft, int pointRight)
        {

            if (pointLeft >= pointRight) //it pointers meet or cross-over, which means everything else has been true, stop
                return true;
            if (text[pointLeft] != text[pointRight]) //if pointers !=, false
                return false;
            
                return IsPalindrome(text, pointLeft + 1, pointRight - 1); //"else" go back into the method passing a "new string" with the pointers moved
        }
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = (Console.ReadLine());

            if (IsPalindrome(input, 0, input.Length - 1)) //assigns locations for pointers at 0 and length-1
                Console.WriteLine($"{input} is a palindrome");
            else
                Console.WriteLine($"{input} is not palindrome");

        }
    }
}
