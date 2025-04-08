using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2a_Create_2D_Array
{
    internal class Program
    {
        //-----------------Create 2d array, print array with formatting
        static void Main(string[] args)
        {
            Console.WriteLine("2D Array Print");

            //GET # rows and colums from user
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int cols = int.Parse(Console.ReadLine());

            //int[,] nums; //declare 2d array named nums
            int[,] nums = new int[rows, cols]; //initializes nums by passing user input rows cols into it

            Console.WriteLine($"Please enter {rows * cols} numbers for your block"); //WRITING the elements for the array

            for (int i = 0; i < rows; i++) //outer loop, rows 1 by 1 top to bottom. i = rows
            {
                for (int j = 0; j < cols; j++) //inner loop, cols 1 by 1 left to right. j = rows
                {
                    Console.Write($"Block [{i}, {j}] "); //goes 0,0 then 0,1 then 0,2...
                    nums[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //READ the data, print it out
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write($"| {nums[i, j]} "); //displays "| row-i col-j value "
                }
                Console.WriteLine("|"); //add line between rows, will start new row with a |
            }
            Console.ReadKey();
        }
    }
}



/*
 * Nested loops
 * outer loops = rows
 *      inner loop = cols
 * 
 * 
 * 
 * Print elements by rows
 * 
 * declare 2d array (2x3 for control)
 *      int[,] arrayname new int[rows, cols]
 *          int[,] matrix = new int[2,3];
 * 
 * iterate through 2d array
 * nested loops to access each element
 *      outer loop = rows
 *      inner loop = cols
 *      
 * print matrix with formatting
 *  outer loops 
 *      inner loop - print elements row by row (write)
 *   writeline
 * 
 */