namespace Mod7_Merge_Sort_Demo_Dave
{
    internal class Program
    {
        static void Divide(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Divide(A, left, mid); //pass A, left, mid (mid as new right), focusing on left part
                Divide(A, mid + 1, right); //focusing on right part
                Merge(A, left, mid, right);

            }
        }

        static void Merge(int[] A, int left, int mid, int right)
        {
            int i = left; //first index of left sub-array you want to start merging with 
            int j = mid + 1; //first index of right sub-array
            int[] B = new int[right + 1]; //declare a temporary array to store the merged elements. right+1 is the size
            int k = left; //index to track elements in array B (temp elements)--needed to move ahead in the temp array
            while (i <= mid && j <= right)
            {
                if (A[i] <= A[j])
                {
                    B[k] = A[i]; //putting the smaller element into the temp array from left side
                    i++; //after that element is put into B, move i
                }
                else //if A[i] > A[j]
                {
                    B[k] = A[j]; //putting right side element into B
                    j++;
                }
                k++; //increment counter in array B
            }
            while (i <= mid) //there were more elements in left array, placing them into the temp array
            {
                B[k] = A[i];
                i++; //increment left side in original array A
                k++; //incremenet counter in temp array B
            }
            while (j <= right) //there were more elements in right array, placing them into temp array
            {
                B[k] = A[j];
                j++; //increment right side in original array A
                k++; //increment counter in temp array B
            }

            for (int x = left; x <= right; x++) //x left til x <= right
            {
                A[x] = B[x]; //put back the sorted sub part in main array
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 34, 12, 1, 45, 9, 11 };
            Divide(A, 0, A.Length - 1);
            foreach(int x in A)
                Console.WriteLine(x);
            Console.ReadKey();


        }
    }
}

/* Quickwatch: A, left, right, mid, i, j, B, A[i], A[j], k
 */