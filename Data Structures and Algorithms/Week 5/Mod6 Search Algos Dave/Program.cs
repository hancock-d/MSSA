using System;
using System.Buffers;
using System.Threading.Channels;

namespace Mod6_Search_Algos_Dave
{
    internal class Program
    {

        //----------LINEAR SEARCH--same as pseudocode in notes
        // Time complexity O(n)
        static int LinearSearch(int[] array, int val) ///input is array, what you're searching is val
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                    return i;
            }
            return -1;
        }

        //----------BINARY SEARCH--same as pseudocode in note
        // Time complexity log(n)

        //----------INTERPOLATION SEARCH METHOD---she did this at 1h30m--uploaded to files
        static int BinarySearch(int[] array, int val) // function ignores edge cases (val at index[0] or last index
        {

            int left = 0, right = array.Length - 1, mid = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (val == array[mid])
                    return mid;
                else if (val < array[mid]) //search the left half
                    right = mid - 1;
                else if (val > array[mid])
                    left = mid + 1; //search the right half

            }
            return -1;

        }
        static void Main(string[] args)
        {


            int[] arr = { 23, 34, 56, 78, 90, 120, 160 };

            Console.WriteLine(BinarySearch(arr, 12)); //pass the array and number 12, will return -1
            Console.WriteLine(BinarySearch(arr, 23)); //will return 0
            Console.WriteLine(BinarySearch(arr, 120)); //will return 5
            Console.WriteLine(BinarySearch(arr, 170)); //will return -1


            void SearchandPrint(int[] array, int val)
            {
                int result = BinarySearch(array, val);
                    if (result == -1)
                    Console.WriteLine("Value outside of array");
                else
                    Console.WriteLine($"Value {val} at index {result}");
            }

            SearchandPrint(arr, 78);  //will print "value 78 is at index 3
        }
    }
}
