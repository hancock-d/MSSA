using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4LinkedListdemo
{
    class Node
    {
        //public int HouseId { get; set; }
        //public string Address { get; set; }
        //public string Type { get; set; }
        public int data;// data 
        public Node next;// address of next node / ref/ link to next 
        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }

    }
    class LList
    {
        // never give access to head and tail to client code, since they can get modified
        private Node head;
        private Node tail;
        private int size;
        public int Size // readonly prop
        {
            get { return size; }
        }
        public LList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        //O(1)
        public void AddFirst(int val)
        {
            Node newNode = new Node(val, null);// new node creation, is already null
            if (IsEmpty())// the list is empty, new node is the only node in list
            {
                this.head = newNode; //head and tail both point to same node, cause there is only one node
                this.tail = newNode;
            }
            else //if another node is already present in the list
            {
                newNode.next = this.head;//point the next link of newnode to the existing first node
                this.head = newNode;// update the head
            }
            size++; //equating number of nodes to the size
        }

        //O(n)
        public void Display()
        {
            Node temp = head;
            if (IsEmpty()) { Console.WriteLine("List is empty"); }
            else
            {
                while (temp != null) //while we have not reached the end
                {
                    if (temp.next != null)  //if temp pointer is not null...
                    {
                        Console.Write(temp.data + " -----> "); //print the arrow
                    }
                    else { Console.WriteLine(temp.data); } // else if at last node , print the value only
                    temp = temp.next;
                }

            }
        }

        // O(1)
        public void AddLast(int val) //adding node at the end
        {
            Node newNode = new Node(val, null); //create new node
            if (IsEmpty()) //if list is empty (no nodes in it)
            {
                this.head = newNode; //head points to new node

            }
            else
            {
                this.tail.next = newNode;// current last node will point to new last node. Putting new node after the last node
                                         // updating the tail
            }
            this.tail = newNode;// updating the tail
            this.size++;
        }

        // o(1)
        public int RemoveFirst() //remove node from the beginning, the first node
        {
            if (IsEmpty()) { Console.WriteLine("List is empty, cannot remove"); return -1; } //returning value to display we removed a node?
            else
            {
                int val = head.data;
                head = head.next; //can start poiinting to the next node
                size--;
                if (IsEmpty())// if there was only 1 node in the list and that was removed
                {
                    tail = null;
                }
                return val;
            }
        }

        //o(n)
        public int RemoveLast()
        {
            if (IsEmpty()) { Console.WriteLine("List is empty!"); return -1; }
            Node temp = head;
            int i = 1;
            //if(size==1)
            //{
            //   return RemoveFirst();
            //}
            while (i < size - 1)// go till second last node
            {
                temp = temp.next;
                i++;
            }
            tail = temp;// we have reached the second last node, so tail points to second last
                        // next 2 steps are to return the last node's val:
            temp = temp.next;
            int val = temp.data; //grab the value from the true last node(?)

            tail.next = null; //tails next should point to null, since it is last node now
            size--;
            return val;
        }

        //o(n)
        public bool Search(int val, out int index)
        {
            Node temp = head;
            int i = 1; //starts at 1, unlike in an array, but still called index i. Index/position tracker
            while (temp != null)
            {
                if (temp.data == val)
                {
                    index = i; //index value as i
                    return true;
                }
                temp = temp.next;
                i++;
            }
            index = -1;
            return false;
        }

        //o(n)
        public void AddAnywhere(int data, int position)
        {
            if (position <= 0 || position > size + 1) //position is either -1 or below or 0 (neither position exists in a linked list) || Makes adding a node to position 11 valid, but cannot skip 11 and add to 12
            {
                Console.WriteLine("Invalid position");
                return; //return from this function
            }
            if (position == 1)
            {
                AddFirst(data);  //passing the value that has been sent to the function
                return;
            }
            if (position == size + 1)
            {
                AddLast(data);
                return;
            }
            Node newNode = new Node(data, null);
            Node temp = head; //points to head of node in place before you want to insert (1-2-2.5-3, insert node 2.5, this points to 2(?))
            int i = 1;
            while (i < position - 1) //will take you to 1 node prior to the position
            {
                temp = temp.next; //temp.next of the new node is pointing to the next node(?)
                i++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            size++;
        }

        public int RemoveAnywhere(int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid position");
                return -1;
            }
            if (position == 1)
            {
                return RemoveFirst(); //returning an integer value that will be passed back
            }
            if (position == size) //you are exactly on the last node you want to remove
            {
                return RemoveLast();
            }

            Node temp = head;
            int i = 1;
            while (i < position - 1) //stopping at 1 node before where you want to be
            {
                temp = temp.next; //temp.next is holding the address for the next node. temp.next.data holds the data for the next node
                i++;
            }
            int data = temp.next.data; //value to be removed (return this value)
            temp.next = temp.next.next; //skips the node in between
            size--;
            return data;

        }

    }
}
