using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_Q_Array
{
    class Q
    {
        private int[] data; //data is an array of ints that can hold size. Is private with or without the access specifier.
        private int front, rear, size;

        //Constructor, sending the size
        public Q(int size)
        {
            this.data = new int[size];  //data is an array of ints that can hold size
            this.front = -1; this.rear = -1;
            this.size = 0;
        }

        public bool IsEmpty() //keeping track of the size
        {
            return this.size == 0;
        }

        public bool IsFull()
        {
            return rear == this.data.Length - 1; //if the rear has reached the end of the array (data.length-1), it's full
        }

        public void Enqueue(int val) //number or value you want to add
        {
            if (IsFull()) { Console.WriteLine("Queue is full, cannot add"); }
            else
            {
                //make sure rear is < data.length-1
                if (rear < data.Length - 1) { rear++; }
                //are these next two blocks happening in the if statement? or where are they happening
                data[rear] = val; //inserting the value in the spot of rear on data array
                size++;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty()) { Console.WriteLine("Q is empty"); return -1; }
            else
            {
                front++;
                size--; //is this changing the size of the array?
                int temp = data[front]; //keep the value of the front 
                if(IsEmpty()) //if this makes the Q empty, set front and rear to -1 (resets the array/Q)
                {
                    this.front = -1;
                    this.rear = -1;
                }
                return temp; //returning first element on the 0th index
            }
        }

        public void Display()
        {
            if (!IsEmpty()) //if not empty
            {
                //display front+1 to the rear, but not front because front is being removed
                for (int i = front + 1; i <= rear; i++)
                {
                    Console.Write(data[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Que is empty");
            }
            Console.WriteLine(); //just leaving a line in between next operation
        }
    }
}
