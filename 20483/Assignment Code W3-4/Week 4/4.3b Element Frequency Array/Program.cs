namespace _4._3b_Element_Frequency_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dummyArray = { 25, 12, 43 };
            Console.WriteLine("Dummy array [25, 12, 43]");
            CountFrequency(dummyArray);

            Console.Write("\nInput size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] userArray = new int[size];
            Console.WriteLine("\nInput {0} elements in the array", size);

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element - {0}: ", i);
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nUser array");
            CountFrequency(userArray);

            Console.ReadKey();
        }

        //METHOD for counting frequency
        static void CountFrequency(int[] arr)
        {
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>(); //create instance of a dictionary<key, value>

            foreach (int i in arr) //iterate through the array to see if it contains the key.
            {
                if (frequencyDict.ContainsKey(i)) //if yes
                {
                    frequencyDict[i]++; //add 1
                }
                else //if not
                {
                    frequencyDict[i] = 1; //count of occurences = 1
                }
            }

            foreach (var pair in frequencyDict)
            {
                Console.WriteLine("{0} occurs {1} times", pair.Key, pair.Value);
            }
        }
    }

}
