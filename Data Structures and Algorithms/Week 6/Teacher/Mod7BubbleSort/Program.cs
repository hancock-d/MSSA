namespace Mod7BubbleSort
{
    internal class Program
    {
        // O(nsq)
        static void BubbleSort(int[]A)
        {
            int temp = 0;
            for(int pass=A.Length-1; pass>=0; pass--)
            {
                for(int i=0;i<pass;i++)
                {
                    if (A[i] > A[i+1])
                    {
                        temp = A[i];
                        A[i] = A[i+1];
                        A[i+1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] A = { 23, 1, 45, 2, 12, 99 };
            BubbleSort(A);
            Console.WriteLine("Sorted array:");
            foreach(int i in A)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
