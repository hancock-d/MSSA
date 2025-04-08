using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2b_Overloading_Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to: ");
            Console.WriteLine("1. Add numbers");
            Console.WriteLine("2. Multiply numbers");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) //if user chooses 1 (add numbers)
            {
                Console.WriteLine("Do you want to add 2 or 3 numbers?");
                int numberInputs = int.Parse(Console.ReadLine());

                if (numberInputs == 2) //if user chooses to add 2 numbers
                {
                    Console.WriteLine("Enter the first number");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    int b = int.Parse(Console.ReadLine());

                    int result = MathOperations.Add(a, b); //creating result as a variable for the Add method passing input a and b
                    MathOperations.WriteResult(result); //calling MathOps class, WriteResult method, passing result
                    //Console.WriteLine($"Result is {result}");
                }
                else if (numberInputs == 3) //else if user chooses to add 3 numbers
                {
                    Console.WriteLine("Enter the first number");
                    decimal a = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    decimal b = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the third number");
                    decimal c = decimal.Parse(Console.ReadLine());

                    decimal result = MathOperations.Add(a, b, c);
                    MathOperations.WriteResult(result);
                }
                else //if user does not choose (to add) 2 or 3 numbers but something else
                {
                    Console.WriteLine("You need to pick how many numbers to add");
                }
            } //closing if loop
            else if (userChoice == 2) //if user chooses 2 (multiply numbers)
            {
                Console.WriteLine("Do you want to multiply 2 or 3 numbers?");
                int numberInputs = int.Parse(Console.ReadLine());

                if (numberInputs == 2)
                {
                    Console.WriteLine("Enter the first number");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    float b = float.Parse(Console.ReadLine());

                    float result = MathOperations.Multiply(a, b);
                    MathOperations.WriteResult(result);
                }
                else if (numberInputs == 3)
                {
                    Console.WriteLine("Enter the first number");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the third number");
                    float c = float.Parse(Console.ReadLine());

                    float result = MathOperations.Multiply(a, b, c);
                    MathOperations.WriteResult(result);
                }
                else //if user does not choose (to multiply) 2 or 3 numbers but something else
                {
                    Console.WriteLine("You need to pick how many numbers to multiply");
                }
            } //closing else if
            else //if user does not choose to 1 Add or 2 Multiply
            {
                Console.WriteLine("You need to choose to either 1) Add or 2) Multiply");
            }
            Console.ReadKey();
        }
    }
}


/* 1) Ask them to choose an operation (add or multiply)
 * 
 * 2a) If add
 * 2b) Ask them if they want to work with 2 or 3 numbers
 * 
 * 2c) if 2 numbers
 *      -ask for the 2 numbers
 *      -declare result = invoke method.class, passing the 2 numbers
 *      -WriteLine result
 *      
 * 2d) else if 3 numbers-decimal
 *      -ask for the 3 numbers
 *      -declare result = invoke overloaded method.class, passing 3 numbers
 *      Writeline result
 *      
 * 2e) else restart the program
 *      
 * 3a) If multiply
 * 3b) Ask them if they want to work with 2 or 3 numbers
 * 
 * 3c) if 2 numbers-float
 *      -ask for 2 numbers
 *      -invoke method, passing the 2 float numbers
 *      -declare result = invoke method.class, passing 2 numbers
 *      -Writeline result
 *      
 * 3d) else if 3 numbers-float
 *      -ask for 3 numbers
 *      -declare result = invoke overloaded method.class, passing the 3 float numbers
 *      -writeline result
 *  
 * 3e) else restart the program
 * 
 * 4a)else (from 2a), retart the program
 * 
 
 write overloaded method for add(int and decimal), multiply (float) for writing result WriteResult
    -must be void because it doesn't return any values, just passes them(result) and writes the result
 */