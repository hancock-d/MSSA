using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Challenge_Lab
{
    public class Program
    {
        static int[] Menu()
        {
            Console.WriteLine("Enter numbers, (int) for an array all on the same line: ");
            string[] stringNums = Console.ReadLine().Split(' ');
            int[] nums = new int[stringNums.Length];

            if (stringNums.Length >= 1)
            {
                for (int i = 0; i < stringNums.Length; i++)
                {
                    nums[i] = int.Parse(stringNums[i]);
                }
            }
            else
            {
                Console.WriteLine("Bad Input");
                Menu();
            }

            return nums;
        }
        static int[] FindBiggestInt(int[] nums)
        {
            int minVal = nums[0];
            int maxVal = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= maxVal)
                {
                    maxVal = nums[i];
                }


                if (nums[i] <= minVal)
                {
                    minVal = nums[i];
                }


            }

            int[] output = { minVal, maxVal };

            return output;
        }
        public static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 33 };

            //int[] answer = FindBiggestInt(nums);

            int[] nums = Menu();

            int[] answer = FindBiggestInt(nums);

            Console.WriteLine("Minimum value: " + answer[0] + ", Maximum Value: " + answer[1]);
        }

        // consider an array of 10 integers and find the biggest number in teh array by writing a function. 
        // No inbuilt functions.
        // The function should return the biggest number to the main method.  Take the array input from teh user
        public static int FindMaxArray(int[] nums)
        {
            int max = int.MinValue;
            foreach (int x in nums)
            {
                if (x > max) { max = x; }
            }

            return max;
        }

        public static int FindMinArray(int[] nums)
        {
            int min = int.MaxValue;
            foreach (int x in nums)
            {
                if (min < x) { min = x; }
            }
            return min;
        }
    }
}