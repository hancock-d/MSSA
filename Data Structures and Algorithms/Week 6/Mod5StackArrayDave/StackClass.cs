using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackArrayDave
{
    class StackArray //can make this StackArray<T> and replace int with T at line 11 (private T[], 29 (push(T val). Only change T where the value type is being...Is this the same as using "var"?
    {
        private int[] data; //int array called data, want to store the...in a linear manner
        private int top;  //top counter, dictates push (increment) and pop (decrement)

        //----MAKE CONSTRUCTOR to set aside memory(?)
        public StackArray(int size) //Constructor
        {
            this.data = new int[size]; //"allocating that much memory" sending the size when creating the stack
            this.top = -1; //initialize top to -1, stack will be empty at beginning
        }

        public bool IsEmpty()
        {
            return this.top == -1;
        }
        public bool IsFull() //make sure the top has reached the max capacity
        {
            return this.top == data.Length - 1; //data is the array, check if the array is at length/stack is full
        }
        public void Push(int val)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full, cannot push anymore items");
                return;
            }
            else
            {
                top++;
                data[top] = val;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                return -1; //have to return something since it's int return type
            }
            int val = data[top];
            top--;
            return val;
        }

        public int Peek()
        {
            if (IsEmpty()) { Console.WriteLine("STack is empty"); return -1; }
            return data[top]; //returning data[top] and returning that, not changing any values
        }

        public void Display()
        {
            if (!IsEmpty())
            {
                for (int i = top; i >= 0; i--) //going from top to bottom, print the value
                {
                    Console.WriteLine(data[i]); //print the data of i (value at i)
                }
            }
            else
            {
                Console.WriteLine("Stack is empty!");
            }
        }
    }
}