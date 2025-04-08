namespace _7._2c_Anagram_Checker
{
    internal class Program
    {
        static bool IsAnagram(string s, string t)
        {
            //Compare length of strings
            if (s.Length != t.Length)
                return false;

            //Convert strings to arrays
            char[] sArray = s.ToLower().ToCharArray();
            char[] tArray = t.ToLower().ToCharArray();

            //Sort the arrays
            Array.Sort(sArray);
            Array.Sort(tArray);

            //Compare arrays
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string s1 = "anagram";
            string s2 = "nagaram";
            string s3 = "rat";
            string s4 = "car";
            string s5 = "Silent";
            string s6 = "listen";
            
            Console.WriteLine(s1 + " vs " + s2);
            Console.WriteLine(IsAnagram(s1, s2));
            Console.WriteLine(s3 + " vs " + s4);
            Console.WriteLine(IsAnagram(s3, s4));
            Console.WriteLine(s5 + " vs " + s6);
            Console.WriteLine(IsAnagram(s5, s6));
        }
    }
}
