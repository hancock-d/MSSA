namespace Challenge_5._2_MissingNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 0, 1 }; //expected 2
            int[] arr2 = { 0, 1 }; //expected 2
            int[] arr3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 }; //expected 8

            Console.WriteLine(BinarySearch(arr1));
            Console.WriteLine(BinarySearch(arr2));
            Console.WriteLine(BinarySearch(arr3));

            //Console.WriteLine(MissingNo(arr1));
            //Console.WriteLine(MissingNo(arr2));
            //Console.WriteLine(MissingNo(arr3));


            Console.ReadKey();
        }
        static int BinarySearch(int[] array)
        {
            Array.Sort(array);

            int left = 0, right = array.Length - 1, mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2; //set mid to middle of array
                if (array[mid] == mid) //index == element, no missing numbers
                {
                    left = mid + 1; //move pointer to right half, missingno is on right half
                }
                else
                {
                    right = mid - 1; //move pointer to left half, missingno is on left half
                }
            }
            return left; //missingno, since if right crosses over left, it means all numbers before left were correct
        }


        //static int MissingNo(int[] array)
        //{
        //    int n = array.Length;

        //    //Calculate sum of array elements
        //    int totalSum = 0;
        //    foreach (int num in array)
        //    {
        //        totalSum += num;
        //    }

        //    //Calculate expected sum
        //    int expectedSum = (n * (n + 1)) / 2;

        //    //Return the missing number
        //    return expectedSum - totalSum;
        //}
    }
}


