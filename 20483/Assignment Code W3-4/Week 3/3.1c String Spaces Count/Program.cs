using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2c_String_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------create a function to input a string and count number of spaces in the string


            Console.WriteLine("Type in a sentence"); //asks user to put in the string
            string userString = Console.ReadLine(); //initializes userString to their input

            //CALL the function (which counts the spaces). need to store that result into a new variable as an int to display
            int numSpaces = CountSpaces(userString);

            //DISPLAY the results/number of spaces
            Console.WriteLine($"Your sentence was: {userString} ");
            Console.WriteLine($"The number of spaces in your sentence is: {numSpaces}");

            Console.ReadKey();

        }

        //CREATE function to count the number of spaces in a string (str)
        static int CountSpaces(string str)
        {
            int count = 0; //initializing count to 0
            foreach (char c in str) //creates c, a variable to represent each character in the string "str"
            {
                if (c == ' ') //if c == a blank space
                {
                    count++; //re-define count to count +1; increment the count by 1
                }
            }
            return count; //returns the total count after every character has been gone through
        }
    }
}


/*
 * Create a function to count spaces
 *      declare a starting count of 0
 *      go through each character in the string
 *          if a character is a space
 *              add 1 to the rolling count
 *      return the total count
 * 
 * Get a string from the user
 * initialize their string to a variable
 * 
 * initialize an int variable to represent the result(return) from the count spaces method
 * 
 * display the number of spaces using that int variable
 * 
 * 
 */