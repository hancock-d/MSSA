using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1TwoDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----Read temps of 4 cities throughout the day

            //                                                        initializing array size 4 (cities, rows) by 4 (temps, columns).
            //            float[,] temperatures = new float[4, 4]; // Total # of elements getting initialized here is 16 (row*col=4*4=16)
            // datatype (float)[,] name = new datatype[rows,cols]

            float[,] temperatures; //--declare the 2d array named temperatures

            Console.WriteLine("2D Array Demo");

            Console.WriteLine("Enter the number of cities (rows)"); //Get #rows from user
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the temperatures received per city (cols)"); //Get #cols from user
            int cols = int.Parse(Console.ReadLine());

            temperatures = new float[rows, cols]; //initializing temperatures by passing user input rows cols into it

            Console.WriteLine($"Please enter {rows * cols} readings of temperatures"); //WRITING THE DATA

            for (int i = 0; i < rows; i++) //outer loop, goes through rows 1 by 1 top to bottom --i indicates rows
            {
                for (int j = 0; j < cols; j++) //inner loop goes through the columns 1 by 1 left to right --j indicates cols
                {
                    Console.Write($"City[{i},{j}] "); //goes 0,0 then 0,1 then 0,2
                    temperatures[i, j] = float.Parse(Console.ReadLine());  //1h16m
                }
            }

            Console.WriteLine("Your entered temperatures are: "); //READING THE DATA
            //getting the 0th dimension (rows, outer) and getting the 1st dimension (cols, inner)
            for (int i = 0; i < temperatures.GetLength(0); i++) //replace rows with getlength of 0--Get number of elements in 1st dimension (rows), then 2nd D
            {
                for (int j = 0; j < temperatures.GetLength(1); j++) //cols--same as up above, different way to write it
                {
                    Console.Write(temperatures[i, j] + "\t");
                }
                Console.WriteLine(); //adds a line between rows
            }
            Console.ReadKey();
        }
    }
}
