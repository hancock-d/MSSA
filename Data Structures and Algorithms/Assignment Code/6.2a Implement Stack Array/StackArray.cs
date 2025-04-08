using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2a_Implement_Stack_Array
{
    class StackArray<T>  //generic type T
    {
        private T[] data; //array called data type T
        private int top; //top counter, dictates push (increment) and pop (decrement)


        //Create constructor
        public StackArray(int size)
        {
            this.data = new T[size]; //data references the new array of [size]
            this.top = -1; // initialize top to -1, stack is empty at creation
        }

        public bool IsEmpty() //check if stack is empty
        {
            return this.top == -1; //if top (counter) is at -1, the stack is empty, returns true (or false is not == -1)
        }

        public bool IsFull() //check if sdtack is full
        {
            return this.top == data.Length - 1; //checking if the top is at the capacity of the array
        }

        public void Push(T val)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full, cannot push more items");
                return; //stops execution
            }
            else
            {
                top++; //increment top
                data[top] = val; //insert new value at the top
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                //return -1;
                return default(T); //return default value for type T (what does this mean?)
            }
            T val = data[top]; //taking top value, assigning it to value
            top--; //decrement/lower the top
            return val; //returning the value
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Peeking, but stack is empty");
                
                return default(T); //whicgh return should I use here?
                //return -1;
            }
            else
            {
                Console.WriteLine("Peeking");
                return data[top]; //just showing the value at the top of the stack
            }
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Stack elemenents from top to bottom");
                for(int i = top; i >=0; i--)
                {
                    Console.WriteLine(data[i]);
                }
            }
        }
    }
}
