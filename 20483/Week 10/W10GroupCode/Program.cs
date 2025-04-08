namespace W10GroupCode
{
    /// <summary>
    /// LEetcode 128
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [100, 4, 200, 1, 3, 2];
            int[] nums2 = [0, 3, 7, 2, 5, 8, 6, 4, 0, 1];

            Console.WriteLine(LongestConsecutrive(nums1));
            Console.WriteLine(LongestConsecutrive(nums2));
        }
        static int LongestConsecutrive(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int maxRun = 0;

            foreach (int num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentRun = 1;

                    while (numSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentRun++;
                    }

                    maxRun = Math.Max(maxRun, currentRun);
                }
            }
            return maxRun;
        }
    }
}




/* 
 * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence
Algorithm must run in O(n) time

Intput: nums = [100,4,200,1,3,2]
Output: 4
Explanation: the longest consecutive elements sequence is [1,2,3,4]. Therefore its length is 4

Example 2:
Inputs: nums = [0,3,7,2,5,8,6,4,0,1]
Output: 9

Sorting--too high of time complexity
*/


/*
 * Create hashset from array
 * minvalue = set.Min(0;
 * count = 0;
 * 
*/