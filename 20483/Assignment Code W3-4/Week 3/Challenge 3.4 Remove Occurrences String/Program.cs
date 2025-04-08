namespace Challenge_3._4_Remove_Occurrences_String
{
    internal class Program
    {
        public static int FinalLength(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                string s2 = s.Replace("AB", "").Replace("CD", ""); //replacing AB and CD with empty slots, saving as s2

                if (s2 == s) //after replacing, compare new s2 with original s (test1/2)
                    break; //if the same, leave the loops
                else
                {
                    s = s2; //if it changed, update s to new length/string
                }
                
            }
            return s.Length;
        }
        static void Main(string[] args)
        {
            string test1 = "ABFCACDB";
            string test2 = "ACBBD";

            Console.WriteLine($"{test1} without AB or CD has revised length of: {FinalLength(test1)}");
            Console.WriteLine($"{test2} without AB or CD has revised length of: {FinalLength(test2)}");

            Console.ReadKey();

        }
    }
}

/* ABFCACDB
    FCACDB --FCAB
        FC
ACBBD -- CANNOT
*/