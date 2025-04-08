using System.Globalization;

namespace _6._1c_Move_All_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 0, 1, 0, 3, 12 }; //output [1, 3, 12, 0, 0]
            int[] array2 = { 0 }; //output [0]

            SwapZeroes(array1);
            PrintArray(array1);
            SwapZeroes(array2);
            PrintArray(array2);
        }


        static void SwapZeroes(int[] arrays)
        {
            int count = 0; //Pointer to track next non-zero element

            for (int i = 0; i < arrays.Length; i++) //iterate thru the array
            {
                if (arrays[i] != 0) //compare current value to 0
                {   
                    //Swap current element with the 0 at index "count"
                    int temp = arrays[i]; //store value into temp
                    arrays[i] = arrays[count]; //put value into count's position
                    arrays[count] = temp; //put i's old value into j
                    count++; //move pointer forward
                }
            }
        }


            static void PrintArray(int[] nums)
        {
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);

                if (i < nums.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
