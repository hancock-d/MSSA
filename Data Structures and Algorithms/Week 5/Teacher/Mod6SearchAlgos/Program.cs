namespace Mod6SearchAlgos
{
    internal class Program
    {
        //O(n)
        static int LinearSearch(int[]array,int val)
        {
            for(int i = 0;i<array.Length;i++)
            {
                if (array[i] == val)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(int[]array,int val)
        {
            int left = 0, right = array.Length - 1, mid = 0;
            while (left <= right)
            {
                mid=(left+right)/2;
                if (val == array[mid])
                    return mid;
                else if (val < array[mid])// search the left half
                    right = mid - 1;
                else if(val > array[mid])
                    left = mid + 1;//search the right half

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 56, 78, 90, 120, 160 };
            BinarySearch(arr,170);
            //Console.WriteLine("Hello, World!");
        }
    }
}
