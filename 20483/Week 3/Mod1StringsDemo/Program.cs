using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //stack, value type. hover over and you'll see "struct"
            string s; //heap, reference type. hover over and you'll see "class"

            // Strings are a sequence of characters enclosed in a double quote " "
            // They are immutable--cannot be changed so a new one will have to be created
            //      when we use + operator with strings, it creates new memory locations/address with 
            //      original + new data and the variable points to new memory address
            // The more + operations, more such strings are created
            //      SO USE A STRING BUILDER

            string address = string.Empty; //created a variable, with nothing in it
            address = "45"; //attached a v
            address = address + " miller street"; //creates a new variable in the heap by pointing to the memory address (


            //      STRING BUILDER
            StringBuilder sb = new StringBuilder();
            sb.Append("45");
            sb.Append(" miller street");

            Console.ReadKey();
            Console.WriteLine(sb.ToString()); //turns it all into a string format to write it
            Console.ReadKey();

            string s1 = "    amazing    ";
            //s1.Trim();
            Console.WriteLine(s1 + " after trimming:" + s1.Trim());

            string header = "* A Short Play. *";
            Console.WriteLine(header);
            var newHeader = header.Trim(new char[] { ' ', '*', '.', ',' }); //create an array of chars to direct which chars to trim
            Console.WriteLine(newHeader);


            Console.WriteLine(newHeader.Replace(' ', '-')); //in newHeader, replacing a single char (space) with dashes
//          Console.WriteLine(newHeader.Replace("  ", " ")); //in newHeader, replaces double space string with a single space

            Console.WriteLine(newHeader.Remove(0, 1)); //removes characters starting at place 0 and stops at place 1


            char[] vowels = { 'A', 'E', 'I', 'O', 'U' }; //creating character array called vowels
            //get or convert all characters into a new string
            string vowelString = new string(vowels);
            foreach (char vowel in vowelString) //going through each character in that string using a foreach loops
            {

            }
            string s2 = "Wake up early. Get to work";
            string[] words = s2.Split(new char[] { ' ', ',', '.' });
            foreach (string word in words)
            {
                if (word != string.Empty) //if word var is not equal to empty, print it
                    Console.WriteLine(word);
            }

            Console.ReadKey();


            var s3 = s2.Substring(0, 5); //getting first 5 characters from s2 as a substring and putting it into a new variable s3
            Console.WriteLine(s3);

            Console.ReadKey();

            //Using reverse, helpful for finding palindromes

            Console.WriteLine("Enter a string to check for palindome");
            var s4 = Console.ReadLine(); //don't have to convert (here) because readline already gives a string
            var s5 = new string(s4.Reverse().ToArray()); //have to convert s4 to an array
            if (s4 == s5)
//          {
                Console.WriteLine("You entered a palindrome");
//          {    ///Since only one line in the if statement, no curly brackets {} required
            else
                Console.WriteLine("Not a palindrome");

            Console.ReadKey();



        }
    }
}
