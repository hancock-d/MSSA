namespace Mod7_Insertion_Sort_Dave
{
    internal class Program
    {
        //O(n^2), stable
        static void InsertionSort(int[] A)
        {
            int temp = 0;
            int position = 0;

            for (int i = 1; i < A.Length; i++)
            {
                temp = A[i]; //temp holding A[i] value
                position = i; //position holds value on the spot

                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position--;
                }
                A[position] = temp;

            }

        }
        static void Main(string[] args)
        {
            int[] A = { 3, 5, 9, 8, 6, 2 };
            InsertionSort(A);

            Console.WriteLine("After sorting: ");
            foreach (var i in A)
            {
                //Console.WriteLine(i);
                Console.Write(i + " ");
            }
        }
    }
}
