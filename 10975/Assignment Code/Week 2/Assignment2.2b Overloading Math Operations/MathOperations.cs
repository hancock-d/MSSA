using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2b_Overloading_Math_Operations
{
    public static class MathOperations
    {

        //---Add 2 integers
        public static int Add(int a, int b) //not void because it receives a and b as parameters, then returns/actions the math of a + b
        {
            return a + b; //returns the value of a + b back to the caller, the part in main that invokes Add
        }
        //---Add 3 decimals, overloaded Add method
        public static decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b + c;
        }
        //---Multiply 2 floats
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        //---Multiply 3 floats, overloaded Multiply method
        public static float Multiply(float a, float b, float c)
        {
            return a * b * c;
        }

        //--Method for displaying result as int
        public static void WriteResult(int result) //must be void because it's not returning any values, just printing the received value/parameter result
        {
            Console.WriteLine($"Result for adding integers is: {result}");
            Console.WriteLine("\nThanks for playing add integers");
        }
        //--overloading for decimal
        public static void WriteResult(decimal result)
        {
            Console.WriteLine($"Result for adding decimals is: {result}");
            Console.WriteLine("\nThanks for playing add decimals");
        }
        //--overloading for float
        public static void WriteResult(float result)
        {
            Console.WriteLine($"Result for multiplying is: {result}");
            Console.WriteLine("\nThanks for playing multiply floats");
        }
    }
}
