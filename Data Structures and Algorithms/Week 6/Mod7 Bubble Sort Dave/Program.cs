namespace Mod7_Bubble_Sort_Dave
{
    internal class Program
    {
        //O(n^2) time complexity
        //is stable--maintains relative order of duplicates
        static void BubbleSort(int[] A)
        {
            int temp = 0;
            bool swapped; //Flag to check if any swaps occurred
            for (int pass = A.Length - 1; pass >= 0; pass--)
            {
                swapped = false; //reset swapped flag before entering next passthrough

                for (int i = 0; i < pass; i++)
                {   //if A[i] is greater than the next consecutive element
                    // how can you stop the process is it is already sorted before pass reaches 0--add boolean flag
                    if (A[i] > A[i + 1])
                    {
                        temp = A[i]; //swapping a[i] and a[i+1]
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true; //mark that a swap has occurred
                    }
                }
                //If no swaps occrred, array is sorted, exit early
                //if (swapped == false)
                if (!swapped) //if swapped is false
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 23, 1, 45, 2, 12, 99 };
            BubbleSort(A);
            Console.WriteLine("Sorted array:");
            foreach (int i in A)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
