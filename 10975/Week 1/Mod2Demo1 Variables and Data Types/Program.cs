using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables and data types demo");

            //data type variable name
            int i; //32 bit signed number
            char c = 'n'; //initialize variable c with value n
            float rateOfInterest = 2.4f;
            string name; //declaring string name
            string address;
            float age;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine(); //ReadLine always returns data in string type
            Console.WriteLine(name + ", where do you live?");
            address = Console.ReadLine();

            Console.WriteLine("Oh, you live in " + address + ". How old are you?");
            age = Convert.ToSingle(Console.ReadLine()); //Convert string from ReadLine to float number
            Console.WriteLine("You're " + age + " years old.");

            int num1, num2; //you can declare multiple variables on the same line
            Console.WriteLine("Enter number 1 and number 2");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("The sum is " + result);

            float divResult = num1 / num2;
            float remainder = num1 % num2;
            Console.WriteLine(divResult + "." + remainder);
            //Console.WriteLine(remainder);


            Console.ReadKey();
        }
    }
}
