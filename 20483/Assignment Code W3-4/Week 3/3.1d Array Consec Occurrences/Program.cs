using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1d_Array_Consec_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------Write a method to take an array as input and finds first occurence of 2 consecutive #s, change value to 0

            //Get the array elements as input from user, pre-defining array size to 6
            Console.WriteLine("Provide 6 numbers/elements for your array");
            int[] numbers = new int[6]; //creates the array numbers with a size of 6

            //populate the array with the user input--for loop?
            for (int i = 0; i < numbers.Length; i++) //goes through the array size 0-5 (array size of 6)
            {
                Console.Write($"Enter element number {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Need to call the function to process the array, passing numbers
            ReplaceOnes(numbers);

            //Display the new array
            Console.Write("New array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);

                if (i < numbers.Length)
                {
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }


        //CREATE function to replace consecutive 1s with 0s, this only creates the updated array and stores it into...array?
    
        public static void ReplaceOnes(int[] array)
        {
            // Go through array
            for (int i = 0; i < array.Length; i++)
            {
                //Check if current element AND next element are 1
                if (array[i] == 1 && array[i+1] == 1)  //if in array, element i = 1 and element i+1 = 1 (element in place 0/i, 0/i+1)
                {
                    array[i] = 0; //change current element to 0
                    array[i + 1] = 0; //change next element to 0
                    return; //exit the loop and return to line 27 where it was called since "my job is done"--stops rewriting double occurrences
                }

            }
            Console.WriteLine("Your array has no double occurrences of the number 1");
        }

    }
}


/*
 * Get user input for the array #s
 * store the input array
 * 
 * Populate the array with the #s from user
 * 
 * 
 * Call the function, passing the user input
 * 
 * Create function:
 * Iterate through the array--for? foreach?--from index 0 to the end
 * Check for consecutive #1s in the array
 *      if current element is 1 AND next element is 1
 *          change the array--current element as 0 and next element as 0
 *          exit loop
 *      return the updates array to the caller
 *      if not, throw exception? Writeline no double occurrences of 1
 *          exit loop
 *      
 * 
 * 
 * 
 * 
 */