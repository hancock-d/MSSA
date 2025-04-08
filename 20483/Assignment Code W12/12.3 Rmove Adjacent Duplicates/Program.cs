namespace _12._3_Rmove_Adjacent_Duplicates
{
    internal class Program
    {
        ////==============12.3 Remove Adjacent Duplicates
        ///LeetCode #1047

        public static string RemoveDuplicates(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count == 0 || stack.Peek() != c)
                {
                    stack.Push(c);
                }
                else
                {
                    stack.Pop();
                }
            }

            char[] result = stack.ToArray();
            Array.Reverse(result);
            return new string(result);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("==============12.3 Remove Adjacent Duplicates\n");
            string s = "abbaca";
            Console.WriteLine($"Input: {s}");
            Console.WriteLine($"Output: {RemoveDuplicates(s)}\n");
            string s2 = "azxxzy";
            Console.WriteLine($"Input: {s2}");
            Console.WriteLine($"Output: {RemoveDuplicates(s2)}\n");

            Console.Write("Provide a test string: ");
            string s3 = Console.ReadLine();
            Console.WriteLine($"Input: {s3}");
            Console.WriteLine($"Output: {RemoveDuplicates(s3)}");
        }
    }
}
