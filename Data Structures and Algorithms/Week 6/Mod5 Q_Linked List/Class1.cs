using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_Q_Linked_List
{
    internal class Node
    {
        public int data; //data stores the integer value inside each node
        public Node next; //go to next node--pointer/reference to the next node in the queue, linking nodes together

        //Constructor, initialize data, 
        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }
    }

    //NEed front and rear (similar to head and tail)

    //LInked LIST Q CLASS
    class Q
    {
        Node front; //have a node called front, the head (stack)
        Node rear; //Node called rear, the tail (stack)
        int size; //size variable, check how many elements are present/tracks # number of elements in queue

        //Constructor to initialize everything
        public Q()
        {
            this.front = null; //this. optional
            this.rear = null;
            this.size = 0;
        }

        //Will not require an IsFull method since the size of a LL is dynamic
        //But you can artificially create a limiting condition (like if you want to limit the size to 10)
        public bool IsEmpty()
        {
            return size == 0; //will tell us if size == 0
        }

        public void Enqueue(int val) //Addlast O(1)
        {
            Node newNode = new Node(val, null); //create a new node, with value as the # and null as the address--So it can be null if there's not following node or will point to rear.next if there is
            if (IsEmpty()) //if no other elements in the Q
            {
                front = newNode; //front points to the newNode that was just/is being created, first element in the Q
                //and rear will be null
            }
            else //if elements are already in the queue
            {
                rear.next = newNode; //adding/attaching newNode after the current rear/tail. rear.next was previously null, but now points to the newNode
            }
            rear = newNode; //updating rear/tail to point to the same node (newNode that was just created)
            size++;
        }


        public int? Dequeue() //Removefirst O(1). nullable int so you can send back a value is int is null
        {
            if (IsEmpty())
            {
                Console.WriteLine("Q is empty");
                return null; //can do -1 but since int is nullable (int?), you can return null
            }
            int val = front.data;
            front = front.next;
            size--;
            //if after decrementing and making the front = front.next
            if (IsEmpty())
            {
                rear = null; //update the tail/rear to point to nothing
            }
            return val; //returning front
        }

        public void Display()
        {
            Node temp = front; //temporary node
            while (temp != null) //while temp node != null, keep incrementing it and keep printing it
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

