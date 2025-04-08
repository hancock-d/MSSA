using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to see?");
            int numbersWanted = int.Parse(Console.ReadLine()); //initializing numbers wanted into numbersWanted

            string[] numbers = new string[numbersWanted]; //creating string [numbers] to the size of numbersWanted
            Console.WriteLine($"Please enter the {numbersWanted} numbers you want to see:"); //asking for the numbers they want to see

            //collect the numbers, put them in my array
            for (int i = 0; i < numbersWanted; i++) //assigns the values to indexes 0-numbersWanted
            {
                Console.Write($"Number[{i + 1}]: "); //asks for numbers to be indexed
                numbers[i] = Console.ReadLine(); //reads the numbers, indexes them
            }
            Console.WriteLine("Those are great numbers! Let's see them.");
            foreach (string n in numbers)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{n} "); //display numbers in original order
                Console.ForegroundColor = ConsoleColor.White;
            }
            //Console.WriteLine(); //adding line break
            //display the array in reverse order
            Console.WriteLine("\nNow let's see them in reverse order!");
            for (int i = numbers.Length - 1; i >= 0; i--) //takes length of numbers and -1 so it starts at last indexed value. subtracts 1 from array length until index 0
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{numbers[i]} "); //displays numbers in reverse order starting at end (numbers.Length) and moving backwards
                Console.ForegroundColor = ConsoleColor.White;
            }

            
            Console.WriteLine("\nPress any key to exit");

            Console.ReadKey();
        }
    }
}


//create an array with n number (input from user)
//display in reverse order, do not use reverse method
//do it using length from end of index to start of index; don't manipulate the data, just display it