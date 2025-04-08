namespace _7._2a_Implement_Shell_Sort
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
                    j = i - gap; //j tracks the left number(?)

                    while (j >= 0 && arr[j] > temp) //only elements > temp get shifted and prevents out of bounds index
                    {
                        arr[j + gap] = arr[j]; //shift larger element to the right by size of gap
                        j = j - gap;  //moves j left by gap
                    }
                    arr[j + gap] = temp;
                    i++;
                }
                gap = gap / 2; //reducing gap
            }
        }

        static void ShellSortFor(int[] arr)
        {
            int n = arr.Length;

            for (int gap = n / 2; gap > 0; gap /= 2) //gap at initial size, halves each loop thru
            {
                Console.WriteLine($"\nGap: {gap}");
                for (int i = gap; i < n; i++) //traverse the array from gap index to end (n)
                {
                    int temp = arr[i]; //store current element
                    int j;

                    Console.WriteLine($"  Considering element at index {i} (value: {temp})");

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap) //compare current element with elements in its group
                    {
                        Console.WriteLine($"      Shifting {arr[j-gap]} from index {j-gap} to index {j}");
                        arr[j] = arr[j - gap]; //shift element right
                    }
                    arr[j] = temp; //insert current element in correct position
                    Console.WriteLine($"   Updated array: [{string.Join(", ", arr)}]");
                }
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

            PrintArray(arr1);
            ShellSortWhile(arr1);
            PrintArray(arr1);

            PrintArray(arr1);
            ShellSortFor(arr1);
            PrintArray(arr1);


        }
    }
}


//public static T GetInput<T>(string prompt)
//{
//    Console.Write(prompt);
//    string userInput = Console.ReadLine();
//    try
//    {
//        var input = Convert.ChangeType(userInput, typeof(T));
//        return (T)input;
//    }
//    catch (Exception exception)
//    {
//        Console.WriteLine($"Please enter input of type {typeof(T).Name}.\nError Message: {exception.Message}");
//        return GetInput<T>(prompt);
//    }
//}