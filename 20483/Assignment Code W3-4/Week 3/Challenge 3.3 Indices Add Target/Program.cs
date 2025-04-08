namespace Challenge_3._3_Indices_Add_Target
{
    internal class Program
    {
        public static int[] FindTarget(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = FindTarget(nums, target);

            Console.WriteLine($"Target number {target} found from sum of indices [{result[0]},{result[1]}]");

            Console.ReadKey();
        }
    }
}


/*
 * function Name(nums, target)
 *      for i from 0 to nums.length -1 --going through the array
 *          for j from i+1 to nums.Length-1; --going through the array+1 slot ahead of i
 *              if nums[i] + nums[j] = target --checking if i + j (index 0 + index 1) = target
 *                  return index [i,j]
 *              
 *                  return null?
 * 
 */