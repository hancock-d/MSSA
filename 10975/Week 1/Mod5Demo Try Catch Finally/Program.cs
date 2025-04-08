using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            float result;
            inputnumbers: //a label, a named location in your code where you can take your code to
            Console.WriteLine("Enter 2 numbers:");

            // 3o
            //int.TryParse() will check first if the string can be converted, if not, it will return a boolean value (false). If yes, it will convert the number and return true
            bool flag1 = float.TryParse(Console.ReadLine(), out num1); //flag variable used when oyu expect a boolean result (true/false)
            bool flag2 = float.TryParse(Console.ReadLine(), out num2); //this will want to return the boolean value and num2 value, out tells it to output num2(or flag2?)

            try
            {
                if (flag1 == true && flag2 == true) //conversion successful can also say if (flag1 && flag2)--more compact
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result is {result}");
                }
                else
                {
                    Console.WriteLine("Numbers are invalid, please re-enter:");
                    goto inputnumbers; //jumps to inputnumbers (line 15) label and starts from the top instead of back to top of if loop
                }
            }
            catch(FileNotFoundException ex)
            {

            }
            catch(SqlException ex)
            {

            }

            catch(Exception e) //can be any variable, e variable will have details of the exception which can be printed on the screen. Generalized catch block, should be last
            {
                Console.WriteLine(e.Message); //writes error in logfile
                Console.WriteLine("Please enter non-zero denominator");
                goto inputnumbers;
            }
            finally
            {
                //mandatory code like closing files, closing database connections, not always necessary (not "compulsory").
                //This code will occur whether or not the error occurred 
            }
            Console.ReadKey();
        }
    }
}
