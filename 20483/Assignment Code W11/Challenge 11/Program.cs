namespace Challenge_11
{

    internal class Program
    {
        ////===============11.1 Sort Color Objects LeetCode #75
        ///Dutch National Flag algorithm

        static void SortColors(int[] nums)
        {
            int low = 0; //Beginning of array
            int mid = 0; //moves through the array
            int high = nums.Length - 1; //End of array

            while (mid <= high)
            {
                if (nums[mid] == 0) //swap low and mid (ensures low will become 0), move pointers forward
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1) //if mid ==1, low stays value 0, mid moves on
                {
                    mid++;
                }
                else if (nums[mid] == 2) //mid==2, swap mid and high, move high inward
                {
                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }
        }

        ////===============11.2 Count Balooons #1189

        static int CountBalloons(string text)
        {

            Dictionary<char, int> count = new Dictionary<char, int>();

            //Had to add these to stop the "key doesn't exist" error
            count.Add('b', 0);
            count.Add('a', 0);
            count.Add('l', 0);
            count.Add('o', 0);
            count.Add('n', 0);


            foreach (char c in text)
            {
                if (count.ContainsKey(c))
                    count[c]++;
                else
                {
                    count.Add(c, 1);
                }
            }

            int result = 0;

            //if (count.Count == 0)
            //    return 0;


            while (count['b'] >= 1 &&
                count['a'] >= 1 &&
                count['l'] >= 2 &&
                count['o'] >= 2 &&
                count['n'] >= 1)
            {
                result++;
                count['b']--;
                count['a']--;
                count['l'] = count['l'] - 2;
                count['o'] = count['o'] - 2;
                count['n']--;
            }

            return result;
        }

        static void PrintArray(int[] nums)
        {
            Console.Write("[ ");
            foreach (var i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 0, 2, 1, 1, 0 }; //[0,0,1,1,2,2]
            int[] nums2 = { 2, 0, 1 }; //[0,1,2]

            Console.WriteLine("===============11.1 Sort Color Objects");
            PrintArray(nums1);
            SortColors(nums1);
            PrintArray(nums1);

            string text = "nlaebolko";
            string text2 = "loonbalxballpoon";
            string text3 = "leetcode";
            string text4 = "";

            Console.WriteLine("\n===============11.2 Maximum Number of Balloons");

            Console.WriteLine(text);
            Console.WriteLine(CountBalloons(text));
            Console.WriteLine(text2);
            Console.WriteLine(CountBalloons(text2));
            Console.WriteLine(text3);
            Console.WriteLine(CountBalloons(text3));
            Console.WriteLine(text4);
            Console.WriteLine(CountBalloons(text4));




        }
    }
}

//(condition) ? (value if true) : (value if false)