using System;
using System.Collections.Generic; //newer version of collections, better way for boxing/unboxing
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//older, created problems with boxing and unboxing like memory issues


namespace Mod10Demo1Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REFERENCES AND VALUES, VAR KEYWORD

            //VAR used when you don't know what the right-hand side will be, like a query expression from a collection or database, will it be a single value, multiple values
            // var k; cannot do this, it must be initialized
            // var k = 5.5f; //will automatically assign the data type to what is on the right side
            var k = new Emp(); //created new employee class at 1h25m -- var now becomes data type class (Emp)

            int i; //value type (allocated on stack)
            i = 10;

            //declare variable type object, the base class to start the hierarchy from System.Object. So it is a reference type since it's from a class (object)
            object obj; //obj holds the memory address from the heap and points to the memory address in the head. obj is now a generic box
            obj = new object(); //instantiating the object
            obj = i; //store any type of value type in obj. Value type getting converted to reference <-- value type to reference type: boxing
            //j = (int)obj; //casting obj back into an integer to put it back into stack. <--reference type to value type: unboxing

            //using System.Collections; older way, avoid using this
            Stack mystack = new Stack();
            mystack.Push(i); //int -- pushing into into obj, to stop of stack ---int boxing
            mystack.Push(4.5f); //float ---float boxing

            //mystack.Pop(); //return value type object, type conversion --unboxing

            //using System.Collections.Generic;  will have <> in the hover-over
            //  Queue<int> q = new Queue<int>(); //what does this do?
            //In the hover-over, T stands for type template
            Stack<int> mystack2 = new Stack<int>();
            //  mystack2.Push ??

            int n1, n2;
            n1 = 56;
            n2 = 78;
            Swap(ref n1, ref n2); //swap values n1 and n2. Calling the function, passing those to values, sending by reference (memory address location)

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            ChangeElements(numbers); //passing numbers of numbers array
            foreach(int temp in numbers)
            {
                Console.WriteLine(temp); //printing the array to see if they got multiplied by 100 or not
            }

            using (UsingWord word = new UsingWord())
            {
                //logic to use your word
            }

            Console.WriteLine($"n1 = {n1} and n2 = {n2}");
            Console.ReadKey();
        }
        //classes, struct
        //{78, 23, 12, 67} 
        static void Swap(ref int num1, ref int num2) //Swap interchanges the values (useful for sorting of data). Function returns void, nothing is returned. Sending by reference # (memory address location)
        {
            int temp = num1;
            num1 = num2; //put data from num1 into num2
            num2 = temp; //num2 can now be overwritten with temp. 
        }
        static void ChangeElements(int[]arr) //base address of array is being sent by default instead of all the numbers, no copy is being created because it array a reference type
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 100;
            }
        }
    }
}
