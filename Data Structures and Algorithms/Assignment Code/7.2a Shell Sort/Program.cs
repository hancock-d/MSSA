namespace _7._2a_Shell_Sort
{
    internal class Program
    {
        static void ShellSortWhile(int[] arr)
        {
            int gap = arr.Length / 2;
            int i, j;

            while (gap > 0)
            {
                i = gap; //i is now holding the value of the gap
                while (i < arr.Length)
                {
                    int temp = arr[i]; //# to be placed at correct position, hold arr[i] while arr[i] is manipulated
                    j = i - gap; //j tracks element that is gap positions left of current element

                    while (j >= 0 && arr[j] > temp) //only elements > temp get shifted and prevents out of bounds index
                    {
                        arr[j + gap] = arr[j]; //shift larger element to the right by size of gap
                        j -= gap;  //moves j left by gap
                    }
                    arr[j + gap] = temp;
                    i++;
                }
                gap = gap / 2; //reducing gap
            }
        }

        static void PrintArray(int[] arr)
        {

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("]");
            
        }


        static void Main(string[] args)
        {
            int[] arr1 = { 2, 15, 8, 10, 7, 4 };
            int[] arr2 = { 2, 7, 8, 1, 5, 3, 2 };


            PrintArray(arr1);
            ShellSortWhile(arr1);
            PrintArray(arr1);
            Console.WriteLine();
            PrintArray(arr2);
            ShellSortWhile(arr2);
            PrintArray(arr2);

        }
    }
}