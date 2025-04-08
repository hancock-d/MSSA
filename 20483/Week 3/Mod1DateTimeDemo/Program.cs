using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //              WRITING A QUERY(?)
            string[] names = { "Amy", "Alex", "Adam", "Zoe", "Frank" };
            // Writing a query, always good to use var. LINQ: Language Integrated Query expressions
            // Searching names in that array. Select name from Tablename where
            var names_A = from name in names //
                          where name.StartsWith("A") //if a name starts with A, it will return true and select that name
                          select name;


            Console.WriteLine("Names starting with A");
            foreach (var n in names_A)
            {
                Console.WriteLine(n);
            }


            //                  DATE TIME
            Console.WriteLine($"It is {DateTime.Now.ToLongDateString()}");
            Console.WriteLine($"The day is {DateTime.Now.Day}");

            Console.WriteLine("Enter your date of birth in yyyy/mm/dd");
            var dob = Convert.ToDateTime(Console.ReadLine()); //using variable dob and converting the info ToDateTime from user input

            var age = CalculateAge(dob);
            Console.WriteLine($"You are {age} years old");
            var months = ((DateTime.Now.Year * 12) + DateTime.Now.Month) - ((dob.Year * 12) + dob.Month);
            float preciseAge = months / 12.0f;
            Console.WriteLine($"Precise age: {preciseAge} years");

            Console.ReadKey();
        }

        //              ADD A FUNCTION, calculate age as whole number

        static int CalculateAge(DateTime dateofbirth) //passing DateTime data type? variable? called dateofbirth
        {
            return DateTime.Now.Year - dateofbirth.Year; //calculating for year only
        }
    }
}
