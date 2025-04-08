namespace Mod7_Shell_Sort_Dave
{
    internal class Program
    {
        //O(nlog(n))
        static void ShellSort(int[] A)
        {
            int gap = A.Length / 2; //6, gap=3
            int i, j;
            while (gap > 0)
            {
                i = gap; //i value holds what the gap is to get the actual value from the array on the index
                while (i<A.Length) //will go while the gap is less than length of the array
                {
                    int temp = A[i]; //hold A[i] in temp so we don't lose it and can put it in the new place after comparison--# to be placed at correct position
                    j = i - gap; 
                    while (j>=0 && A[j]>temp) 
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp; //final position for temp element
                    i++; //increment i (temp variable for gap) while i<length of array
                }
                gap = gap / 2;
            }
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 5, 8, 9, 6, 2 };
            ShellSort(A);
            foreach (int i in A) { Console.WriteLine(i); }

        }
    }
}
