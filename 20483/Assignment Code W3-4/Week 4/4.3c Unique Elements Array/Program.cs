namespace _4._3c_Unique_Elements_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dummy Data: [1, 5, 1, 3, 7, 3, 8]");
            int[] numbers = { 1, 5, 1, 3, 7, 3, 8 };
            FindUniqueElements(numbers);


            Console.Write("\nInput size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] userArray = new int[size];
            Console.WriteLine("\nInput {0} elements in the array", size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element - {0}: ", i);
                userArray[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine($"\nUser array [{userArray}]"); //do a for each loop to print this out properly
            Console.Write($"\nUser Array [ ");
            foreach (var i in userArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("]");
            FindUniqueElements(userArray);

            Console.ReadKey();
        }

        static void FindUniqueElements(int[] numbers)
        {
            Dictionary<int, int> countDict = new Dictionary<int, int>(); //<key (actual number from array), value (count of how many times that # appears)>

            foreach (int num in numbers) //iterates over each number in the numbers array
            {
                if (countDict.ContainsKey(num)) //if num is already a key in countDictionary
                {
                    countDict[num]++; //increment its count
                }
                else
                {
                    countDict[num] = 1; //if not, add it to the dictionary, set count as 1
                }
            }
            Console.WriteLine("Unique elements found in the array: ");
            foreach (var pair in countDict)
            {
                if (pair.Value == 1)  //if value (count) only appears 1x
                {
                    Console.WriteLine(pair.Key); //write the key (number from array)
                }
            }
        }

    }
}
