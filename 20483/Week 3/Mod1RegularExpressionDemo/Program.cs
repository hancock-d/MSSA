using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mod1RegularExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                      VALIDATING STRINGS
            input: //Creating label input
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if(ContainsDigits(name)) //if name contains digits, will return true and execute the IF portion
            {
                Console.WriteLine("Enter only letters");
                goto input;
            }
            else //if name does not contain digits, will return fals and continue through ELSE block
            {
                emailinput:
                Console.WriteLine($"{name}, please enter your email id");

                string email = Console.ReadLine();
                if(CheckEmail(email))
                {
                    Console.WriteLine($"{name}, you registered successfully at {email}");
                }
                else
                {
                    Console.WriteLine("Invalid email format, please re-enter");
                    goto emailinput;
                }
            }

            Console.ReadKey();

        }


        //          WRITE A NEW METHOD TO VALIDATE THE STRING


        static bool CheckEmail(string email)
        {
            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailpattern); //checking email with emailpattern
        }
        static bool ContainsDigits(string s) //pass the string to it that you want to validate, will return 
        {
            return Regex.IsMatch(s, "\\d");  //if it sees a digit in string s, it will return true
        }
    }
}
