using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2d_Calculate_Total_Average_Method
{
    //---------------Calculate Total Average Method
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            float average;
            int[] values = {10, 15, 20, 30};

            Results(out sum, out average, values); //calling Results, putting out sum and average, using values array

            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Average of numbers: {average}");
        }

        //Write the method to calculate the sum and average, use foreach loop
        static void Results(out int sum, out float average, params int[] values)  //how is this line read? verbiage?
        {
            sum = 0;
            
            foreach (int i in values)
            {
                //sum = sum + i;
                sum += i;
            }

            float addSum = sum; //created a new variable to hold sum as a float value
            average = addSum / values.Length; //dividing sum by the length of the values array
        }

    }
}


/*
 * Call the method for 4 numbers, hard code the number
 * MethodName(out
 * 
 * Display the results 
 * 
 * 
 * 
 * 
 * 
 * 
 */