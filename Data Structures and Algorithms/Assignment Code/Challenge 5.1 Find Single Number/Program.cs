namespace Challenge_5._1_Find_Single_Number
{
    internal class Program
    {
        static int FindSingleNumber(int[] nums)
        {
            //create new dictionary
            Dictionary<int, int> numCount = new Dictionary<int, int>(); //<key (#), value (freq)>

            foreach (int num in nums) //count occurrences of each number
            {
                if (numCount.ContainsKey(num)) //if number exists in the dictnioary...
                    numCount[num]++; //increase the count/value of the existing key by 1
                else
                    numCount[num] = 1; //adds new key to numCount with initial value 1
            }

            //iterate thru the dictionary to find the pair with value == 1
            foreach (var pair in numCount) //find the number that appears only once
            {
                if (pair.Value == 1)
                    return pair.Key;
            }
            return -1; //if no matches


        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            Console.WriteLine(FindSingleNumber(nums)); //output 1
            int[] nums2 = { 4, 1, 2, 1, 2 };
            Console.WriteLine(FindSingleNumber(nums2)); //output 4
            int[] nums3 = { 1 };
            Console.WriteLine(FindSingleNumber(nums3)); //output 1
            int[] nums4 = { 1, 1, 2, 2 };
            Console.WriteLine(FindSingleNumber(nums4)); //output -1


        }
    }
}
