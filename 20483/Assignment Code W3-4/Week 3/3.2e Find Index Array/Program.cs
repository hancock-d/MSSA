using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2e_Find_Index_Array
{
    //------------------Find the index of a given item in the array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 5, 3 }; //search for 5
            int[] array2 = { 9, 8, 3 }; //search for 3
            int[] array3 = { 1, 2, 3 }; //search for 4

            int index1 = Search(array1, 5);
            Console.WriteLine($"Searching first array for value 5: {index1}");
            int index2 = Search(array2, 3);
            Console.WriteLine($"Searching second array for value 3: {index2}");
            int index3 = Search(array3, 4);
            Console.WriteLine($"Searching third array for value 4: {index3}");

         }

        public static int Search(int[] newArray, int target)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] == target) //compares array element i against target. i == target compares the INDEX to the target
                {
                    return i;
                }
                //else
                //{
                //    //return -1;
                //}
                ////return -1;
            }
            return -1;
        }
    }
}


/*
 * Create 3 arrays        int[] array1 = {1, 2, 3};
 * 
 * invoke Search on array1/2/3 passing 5/3/4
 * ----Search(array1, 5), which will return i or -1
 * Display the result
 * 
 * Search()
 * 
 * For Loop through each element in array (i, <array.Length, i++)
 *      if i == target
 *          return i
 *      else
 *          ? return -1?
 * 
 * 
 * 
 * Loop through array-for loop
 * Check if current element matches the target number
 *      If match is found, return the INDEX, not the element/value
 *      If NO match, return -1
 * 
 * 
 * 
 * 
 */