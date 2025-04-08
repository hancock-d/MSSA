using System.Text;

namespace _7._1b_Merge_Strings
{
    internal class Program
    {
        //static string MergeAlternately(string s1, string s2)
        //{
        //    //Remove spaces from input strings
        //    s1 = s1.Replace(" ", "");
        //    s2 = s2.Replace(" ", "");

        //    // Store final string
        //    string result = "";

        //    // For every index in the strings...
        //    for (int i = 0; i < s1.Length || i < s2.Length; i++)
        //    {
        //        //Choose the ith char of s1
        //        if (i < s1.Length)
        //            result += s1[i]; //add to result string
        //        //Choose the ith char of s2
        //        if (i < s2.Length)
        //            result += s2[i]; //add to result string
        //    }
        //    //when loop finishes...
        //    return result;
        //}

        //Use stringbuilder to reduce the amount of extra strings made
        static string MergeAlternately(string s1, string s2)
        {
            s1 = s1.Replace(" ", "");
            s2 = s2.Replace(" ", "");

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < s1.Length || i < s2.Length; i++)
            {
                if (i < s1.Length)
                result.Append(s1[i]);

                if (i < s2.Length)
                    result.Append(s2[i]);
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "pqr";
            Console.WriteLine(s1 + " + " + s2);
            Console.WriteLine(MergeAlternately(s1, s2));
            Console.WriteLine();

            string s3 = "ab";
            string s4 = "pqrs";
            Console.WriteLine(s3 + " + " + s4);
            Console.WriteLine(MergeAlternately(s3, s4));
            Console.WriteLine();

            string s5 = "a b c d";
            string s6 = "y z";
            Console.WriteLine(s5 + " + " + s6);
            Console.WriteLine(MergeAlternately(s5, s6));

        }
    }
}
