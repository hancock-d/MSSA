using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._4aSumArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------Write a program to find the sum of all array elements
            Console.WriteLine("How many numbers do you want to store in the array? ");
            int numElements = int.Parse(Console.ReadLine()); // reading user input, coverting to int

            // declaring an int array named array to hold the elements, with size numElements provided by the user.
            int[] array = new int[numElements];

            // get array elements from user
            Console.WriteLine($"Input {numElements} numbers for the array:");

            // initializing variable sum to store the total sum of array elements
            int sum = 0;

            // use a for loop to read each element of the array and assign the element a value from the user
            for (int i = 0; i < numElements; i++) //cannot be <=, that will go to a non-existant additional index
            {
                // show element index and ask for its value
                Console.Write($"Element {i} : ");
                // read the input, convert to integer, store it in the array
                array[i] = int.Parse(Console.ReadLine());

                // changing sum to add current sum + value of new index
                sum = sum + array[i];
             
            }

            // show sum of all elements in array
            Console.WriteLine($"\nSum of all elements stored in the array is: {sum}");

            Console.ReadKey();
        }
    }
}



/*
 * Declare array to hold elements--size of array is provided by user
 * Ask user for array size and elements
 *  Get numbers/elements for the array from user
 * create sum
 * iterate through the array with the size numElements
 * 
*/