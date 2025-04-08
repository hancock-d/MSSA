namespace Mod7_Quick_Sort_Demo_Dave
{
    internal class Program
    {
        static void QuickSort(int[] A, int low, int high)
        {
            if (low < high)
            {
                int p_index = Partition(A, low, high);
                QuickSort(A, low, p_index - 1); //left part sorted first
                QuickSort(A, p_index + 1, high); //right part sorted 
            }
        }
        //this method returns the pivot/partition index which is actually the correct spot for the first number
        static int Partition(int[] A, int low, int high)
        {
            int pivot = A[low]; //we start with first element to be placed in right spot
            int i = low;
            int j = high;
            do
            {
                while (i <= j && A[i] <= pivot) //compare element at ith position with pivot
                {
                    i++; //i moves right
                }
                while (i <= j && A[j] > pivot)
                {
                    j--; //j moves left
                }
                if (i <= j) //i and j have not yet crossed each other but they stopped
                {
                    //swap
                    Swap(A, i, j);
                }

            } while (i < j); //j has crossed i, found pivot position


            if (low != j) //don't swap with itself
            {
                Swap(A, low, j);
            }
            return j; //j is now the partition index p_index
        }
        static void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        static void Main(string[] args)
        {
            int[] A = { 54, 78, 63, 92, 45, 86, 15, 28, 37 };
            QuickSort(A, 0, A.Length - 1); //-1 or +1 depends on where j is decremeted
            foreach (int i in A)
                Console.WriteLine(i);

        }
    }
}
