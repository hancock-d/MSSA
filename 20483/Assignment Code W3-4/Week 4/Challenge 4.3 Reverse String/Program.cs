namespace _4._3_Challenge_Reverse_String
{
    internal class Program
    {
        static void ReverseString(char[] s)
        {
            //creating pointers, helps not have to do for loops by using swap. They'll increment/decrement thru array until they meet/cross-over
            int left = 0; //starts left at first index
            int right = s.Length - 1; //starts right at last index

            while (left < right) //as long as the index of left < index of right, it will run. When left==right or left>right, they've gone through the array
            {
                char holder = s[left]; //holder = index 0 to start
                s[left] = s[right]; //swaps index 0 with index length-1...
                s[right] = holder; //reassigns s[right] to what holder was

                left++; //move the left pointer to the right
                right--; //move the right pointer to the left
            }
        }
        static void Main(string[] args)
        {
            char[] hello = { 'h', 'e', 'l', 'l', 'o' }; //creating char array hello
            char[] hannah = { 'H', 'a', 'n', 'n', 'a', 'h' };
            char[] party = { 'p', 'a', 'r', 't', 'y' }; 


            //Console.WriteLine($"Before: {hello.ToString()}"); //doesn't work for arrays
            Console.WriteLine($"Before: {new string(hello)}"); //converts hello to string from array
            ReverseString(hello);
            Console.WriteLine($"After: {new string(hello)}");

            Console.WriteLine($"Before: {new string(hannah)}");
            ReverseString(hannah);
            Console.WriteLine($"After: {new string(hannah)}");

            Console.WriteLine($"Before: {new string(party)}");
            ReverseString(party);
            Console.WriteLine($"After: {new string(party)}");

            Console.ReadKey();
        }
    }
}
