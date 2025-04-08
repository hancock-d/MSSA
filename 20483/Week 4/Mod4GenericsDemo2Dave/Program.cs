namespace Mod4GenericsDemo2Dave
{
    class Person //only creating the class here for the sorted dictionary example
    {
        public string Name { get; set; }
        public int phoneNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            n1 = 34;
            n2 = 56;

            //in the <>. specify what you want to swap
            Swap<int> swapint = new Swap<int>();  //create a new object (instance) of the generic class Swap<T>
            swapint.SwapData(ref n1, ref n2);  //T is replaced by int

            //REUSE generic Swap method template for a different data type
            float f1, f2;
            f1 = 3.4f;
            f2 = 5.6f;

            Swap<float> swapfloat = new Swap<float>(); //replace T with the data type
            swapfloat.SwapData(ref f1, ref f2);

            //IF STATIC CLASS AND THEREFORE STATIC METHOD
            //Swap<int>.SwapData.SwapData(ref n1, ref n2);

            //NOT SURE WHAT DOING HERE 4 Feb @ 1h20m
            Stack<int> ints = new Stack<int>();  //

            //NOT SURE HERE
            CustomList<int> customList = new CustomList<int>();

            //EXMAPLE of SORTED DICTIONARY ///4 Feb @ 1h38m
            SortedDictionary<string, Person> phonebook = new SortedDictionary<string, Person>(); //Sorts the dictionary alphabetically. If you remove Sorted, it'll just show the data in order as provided
            phonebook.Add("Zoe", new Person() { Name = "Zoe", phoneNumber = 242424 }); //new Person().... is an instance of the Person class
            phonebook.Add("Amy", new Person() { Name = "Amy", phoneNumber = 353535 }); //"Amy" is key, object new Person() {Name...}) is value
            foreach (Person p in phonebook.Values) //have to use .Values because Person P is person, phonebook is a collection
            {
                Console.WriteLine(p.Name + " " + p.phoneNumber);
            }

            Console.ReadKey();

        }
        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void swap(ref float x, ref float y)
        {
            float temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
