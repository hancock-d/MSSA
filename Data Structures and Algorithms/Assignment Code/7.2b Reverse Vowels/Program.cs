namespace _7._2b_Reverse_Vowels
{

    internal class Program
    {
        static string ReverseVowels(string s)
        {
            char[] arr = s.ToCharArray(); //convert string to char array
            int left = 0, right = arr.Length - 1; //pointers
            string vowels = "aeiouAEIOU";

            while (left < right)
            {

                //Move left pointer inward if not a vowel
                if (!vowels.Contains(arr[left]))
                {
                    left++;
                    continue; //jump to top of while loop
                }
                //Move right pointer inward if not a vowel
                if (!vowels.Contains(arr[right]))
                {
                    right--;
                    continue;
                }

                //when both pointers find a vowel, they stop and swap
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                //after swap occurs, move pointers
                left++;
                right--;
            }
            return new string(arr); //new string instance from the array
        }
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "Avocado";
            string s3 = "intelligent";
            string s4 = "Hello world";

            Console.WriteLine(s1);
            Console.WriteLine(ReverseVowels(s1));
            Console.WriteLine(s2);
            Console.WriteLine(ReverseVowels(s2));
            Console.WriteLine(s3);
            Console.WriteLine(ReverseVowels(s3));
            Console.WriteLine(s4);
            Console.WriteLine(ReverseVowels(s4));
        }
    }
}
