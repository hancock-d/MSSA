namespace _11._3b_Majority_Element
{
    internal class Program
    {
        ///=========11.3b Majority Element
        static int MajorityElement(int[] arr)
        {
            int n = arr.Length;

            Dictionary<int, int> kvp = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (!kvp.ContainsKey(i))
                {
                    kvp.Add(i, 1);
                }
                else
                {
                    kvp[i]++;
                }
                if (kvp[i] > n / 2)
                {
                    return i;
                }
            }
            return -1; //have to return something
        }

        ///=========11.2a Rank Transform Array
        static int[] RankedArray(int[] arr)
        {
            int[] arrCopy = new int[arr.Length];
            Array.Copy(arr, arrCopy, arr.Length);
            Array.Sort(arrCopy);

            Dictionary<int, int> ranksDict = new Dictionary<int, int>();
            int rank = 1;

            foreach (int i in arrCopy)
            {
                if (!ranksDict.ContainsKey(i))
                {
                    ranksDict[i] = rank;
                    rank++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ranksDict[arr[i]]; //replace each value in original array with its rank
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("[ ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=========11.3b Majority Element");
            int[] nums1 = { 3, 2, 3 };
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2, };

            Console.WriteLine("For array: ");
            PrintArray(nums1);
            Console.WriteLine(MajorityElement(nums1)); //3
            Console.WriteLine("For array: ");
            PrintArray(nums2);
            Console.WriteLine(MajorityElement(nums2)); //2

            Console.WriteLine("=========11.2a Rank Transform Array");
            int[] arr1 = { 40, 10, 20, 30 }; //[4,1,2,3]
            int[] arr2 = { 100, 100, 100 }; //[1,1,1]
            int[] arr3 = { 37, 12, 28, 9, 100, 56, 80, 5, 12 }; //[5,3,4,2,8,6,7,1,3]

            Console.WriteLine("For array: ");
            PrintArray(arr1);
            RankedArray(arr1);
            PrintArray(arr1);
            Console.WriteLine("For array: ");
            PrintArray(arr2);
            RankedArray(arr2);
            PrintArray(arr2);
            Console.WriteLine("For array: ");
            PrintArray(arr3);
            RankedArray(arr3);
            PrintArray(arr3);

        }
    }
}
