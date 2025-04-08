using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args) //this is the main method
        {
            /*Array is a fixed size collection of same data type, where memory is allocated continuously
             * allocated in heap memory. Elements can be accessed by their index and by defaultthe first
             * index is 0
             * datatype [] nameofarray = new int [size]
             */


            //5 integer elements
            int[] numbers = new int[5]; //creating an array type int called numbers, of 5 integers
            numbers[0] = 1; //in first index 0, number 1 is stored in it
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5; //array is only 5 in size, stop here. if you do more, you'll get a runtime error
            // numbers[5] = 6; //this is out of range
            Console.WriteLine("Array demo");
            Console.WriteLine("Please enter 5 numbers"); //getting user from into for the numbers in the array, will overwrite hardcoded part
            for (int i = 0; i < numbers.Length; i++) //using for loop to get new array numbers from user
            {
                numbers[i] = int.Parse(Console.ReadLine()); //will read user input for array index 0-4 (5 count), overwrites numbers
            }
            Console.WriteLine("You entered the following numbers:");
            for (int i = 0; i < numbers.Length; i++) //using for loop to print user values
            {
                Console.Write(numbers[i] + " "); //writes each number on the same line
            }
            Console.WriteLine();

            Array.Reverse(numbers); //reverses the numbers from the numbers array (passing numbers)
            Console.WriteLine("Reversed number array is as follows:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i); //writes each number on a new line
            }

            //              Create an Array of Temperatures
            Console.WriteLine();
            float[] temperatures = { 56.5f, 66f, 70.4f }; //temp array size 3, array initialized. Read as float array temperatures

            // Nullable<float>[] temps = new Nullable<float>[3]; //stores null, which means no record. Important to differentiate between 0 as a value and null as a value

            Array.Resize(ref temperatures, 5); //references the temperature array, resizes it from 5 to 3. No values assigned for array indexes the 2 new allocations
            foreach (float f in temperatures) //f is a temporary loop variable representing each element, can name it whatever you want
            {
                Console.WriteLine(f);
            }

            //              Create an Array of Names
            string[] names = { "Zoe", "Amy", "Frank", "Nathan" }; //establishing array of names
            //Console.WriteLine(names[0]); writes Zoe only
            Array.Sort(names); //sorts all the names

            //foreach loop doesn't need the index. use the foreach mainly while doing reading / iteration of data. Cannot use it for user input
            Console.WriteLine("Sorted array is:");
            foreach (string name in names) //creates a temp variable name and points to each name in names
            {
                Console.WriteLine(name); //prints the name in array names
            }


            //              Create an Array oh Hobbies
            Console.WriteLine();
            Console.WriteLine("How many hobbies do you have?");
            int numOfHobbies = int.Parse(Console.ReadLine());

            string[] hobbies = new string[numOfHobbies]; //using the size of number of hobbies?
            Console.WriteLine($"Please enter {numOfHobbies} hobby/hobbies ");

            //collect the hobbies, put them in your array
            for(int i=0;i<numOfHobbies;i++) //or can be num.length(?)
            {
                Console.Write($"Hobby[{i+1}]: "); //asks for hobbies and indexes up to number of hobbies input. i+1 will from starting at 1; i will start printing at 0
                hobbies[i] = Console.ReadLine();
            }
            Console.WriteLine("You have great hobbies:");
            foreach(string s in hobbies)
                {
                Console.WriteLine(s);
                }


            Console.ReadKey();

        }
    }
}
