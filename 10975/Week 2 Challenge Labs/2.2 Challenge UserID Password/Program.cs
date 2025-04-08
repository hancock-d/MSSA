using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_UserID_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "admin";
            string password = "Password";
            int maxAttempts = 3;

            int attempt = 0;

            Console.WriteLine("You will be locked out after 3 attempts\n");

            while (attempt < maxAttempts)
            {
                attempt++; //moved this up here or the counter gets off

                Console.WriteLine($"Login attempt #{attempt}");
                Console.WriteLine("Please enter your user ID: ");
                string userId = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter your password, it is case sensitive: ");
                string userPassword = Console.ReadLine();

                Console.WriteLine();

                if (userId == id && userPassword == password)
                {
                    Console.WriteLine($"Login successful, welcome {userId}");
                    Console.WriteLine("\nPlease press any key to continue");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Login unsuccessful.");
//                    attempt++;
                }

                if (attempt == maxAttempts)
                {
                    Console.WriteLine("Maximum attempts reached.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
            }
        }
    }
}

/* 
 * Hard code String ID, Password, maxattempts
 * 
 *
 * while (user attempts <3)
 *  get user input ID
 *  get user input password
 *  
 *  ---check user values against hard values
 *  if user = hard for both ID and password
 *      -login successful
 *      -exit loop
 *  else 
 *      -login unsuccessful, attempt # x of 3
 *      -attempt++
 * 
 * --if at max attempt 3/3, quit
 * 
 * close while
 * 
 * 
 * 
 * 
 * 
 * 
*/
