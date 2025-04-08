using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2b_Add_2_Matrices
{
    //---------------Adding 2 matrices
    internal class Program
    {

        static void Main(string[] args)
        {
        StartOver: //cheating on this label
            // GET matrix size
            Console.Write("Input the size of the matrix (from 1 to 4): \n");
            //int matrixSize = 3; //sets the matrixSize to 3 (same as line 30)
            int matrixSize = int.Parse(Console.ReadLine());

            if (matrixSize <= 0 || matrixSize >= 5)
            {
                Console.WriteLine("Size must be from 1 to 4");
                //return; //exit the main method until I write another way to start over
                goto StartOver; //cheap way to start over for now
            }
            Console.WriteLine();

            // INITIALIZE matrices
            //int[,] firstMatrix = new int[3,3]; //initializes array at size 3x3
            int[,] firstMatrix = new int[matrixSize, matrixSize]; //using matrixSize for both since they're the same size
            int[,] secondMatrix = new int[matrixSize, matrixSize]; //declares a 2D array of ints, allocating memory with matrixSize
            int[,] resultMatrix = new int[matrixSize, matrixSize]; //result matrix will also be that size

            //GET firstMatrix values, nested for loops
            Console.WriteLine("Enter the values for the first matrix");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"Element at index [{i}] [{j}] : "); //starting at i=0 and j=0, get elements for each matrix index
                    firstMatrix[i, j] = int.Parse(Console.ReadLine()); //reading the input, assigning it to the index
                }
            }
            Console.WriteLine();

            //GET secondMatrix values, nested for loops
            Console.WriteLine("Enter the values for the second matrix");

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"Element at index [{i}] [{j}] : ");
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //DISPLAY both matrices, same as assignment 3.2a
            //First Matrix
            Console.WriteLine("The first matrix is:");
            for (int i = 0; i < matrixSize; i++) //don't need GetLength because matrixSize is an int that holds the size of the matrix, not iterating through an array
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"[ {firstMatrix[i, j]} ]"); //displays "| row-i col-j value |"
                }
                Console.WriteLine(); //Blank line to start a new line for the next row
            }
            Console.WriteLine();

            //Second Matrix
            Console.WriteLine("The second matrix is:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"[ {secondMatrix[i, j]} ]");
                }
                Console.WriteLine(); //space to separate rows
            }
            Console.WriteLine();

            //Console.ReadKey();

            //ADD the matrices together
            Console.WriteLine("Adding the two matrices, please wait...\n");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j]; //defining the new values for resultMatrix
                }
            }

            //DISPLAY resultMatrix
            Console.WriteLine("The final matrix is:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"[ {resultMatrix[i, j]} ]");
                }
                Console.WriteLine(); //space for row separation
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}


/*
 * Input Matrix size
 *      ask user for size of the matrix
 *      Ensure the size is <5
 * 
 * Initialize all three matrices, all same size
 *      declare 2x2D arrays of size [size, size] to store user inputs
 *          int[,] 1-2-3rd matrix = new int [size,size]
 *      
 * Get user input for firstMatrix
 *      nested for loop to iterate through rows and cols
 *      get user values for each element
 *      
 * Get user input for secondMatrix
 *      nested for loop to iterate through rows and cols
 *      get user values for each element
 *      
 * Display both Matrices
 *      print first matrix using a loop
 *      print second matrix using a loop
 *      
 * Add the two matrices
 *      Create 3rd matrix to store sum of corresponding elements from first and second matrix
 *      nested loop to add corresponding elements frm both matrices
 *      
 * Display resultMatrix
 *      display matrix after the addition using a loop
 * 
 * 
 * 
 * 
 * 
 */