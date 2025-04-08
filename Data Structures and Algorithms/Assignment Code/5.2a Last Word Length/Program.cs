namespace _5._2a_Last_Word_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world has " + LastWord("Hello world")); //5
            Console.WriteLine("Fly me to the moon has " + LastWord(" fly me to the moon ")); //4* --Had to use trim to get the trailing space off
            //Console.WriteLine("     has " + LastWord("   ")); //0
            //Console.WriteLine("! has " + LastWord("!")); //1 This is also incorrect
            //Console.WriteLine("1 has " + LastWord("1")); //1 This is incorrect

        }

        public static int LastWord(string s)
        {
            string[] words = s.Trim().Split(' '); //splits the string into an array wherever there is a ' ' char.  Trim to cut off whitespace chars at start/end

            //if (string.IsNullOrEmpty(s))
            if (string.IsNullOrWhiteSpace(s))
                return 0; //returns 0 as size since there's no input
            else
            {
                return words[words.Length - 1].Length; //accesses last word in array and its length
            }
        }
    }
}
