using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4LinkedListdemo
{
    class Node
    {
        //public int HouseId {  get; set; }
        //public string Address { get; set; }
        //public string Type {  get; set; }
        public int data;// data 
        public Node next;// address of next node / ref/ link to next 
        public Node(int val,Node next)
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
            Node newNode = new Node(val, null);// new node creation
            if(IsEmpty())// the list is empty, new node is the only node in list
            {
                this.head= newNode;
                this.tail= newNode;
            }
            else
            {
                newNode.next = this.head;//point the next link of newnode to the existing first node
                this.head = newNode;// update the head
            }
            size++;
        }

        //O(n)
        public void Display()
        {
            Node temp = head;
            if(IsEmpty() ) { Console.WriteLine("List is empty"); }
            else
            {
                while( temp != null )
                {
                    if (temp.next != null)
                    {
                        Console.Write(temp.data + " -----> ");
                    }
                    else { Console.WriteLine(temp.data); } // last node , print the value only
                    temp = temp.next;
                }

            }
        }

        // O(1)
        public void AddLast(int val)
        {
            Node newNode = new Node(val, null);
            if(IsEmpty())
            {
                this.head = newNode;
                
            }
            else
            {
                this.tail.next = newNode;// current last node will point to new last node
               // updating the tail
            }
            this.tail = newNode;// updating the tail
            this.size++;
        }

        // o(1)
        public int RemoveFirst()
        {
            if (IsEmpty()){ Console.WriteLine("List is empty , cannot remove");return -1; }
            else
            {
                int val=head.data;
                head=head.next;
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
            while(i<size-1)// go till second last node
            {
                temp = temp.next;
                i++;
            }
            tail= temp;// we have reached the second last node, so tail points to second last
            // next 2 steps are to return the last node's val:
            temp = temp.next;
            int val=temp.data;

            tail.next = null; //tails next should point to null, since it is last node now
            size--;
            return val;
        }

   //o(n)
        public bool Search(int val, out int index)
        {
            Node temp = head;
            int i = 1; // position
            while(temp!= null)
            {
                if(temp.data==val)
                {
                    index = i;
                    return true;
                }
                temp = temp.next;
                i++;
            }
            index = -1;
            return false;
        }

        //o(n)
        public void AddAnywhere(int data,int position)
        {
            //-1, 0 10 11   12
            if (position<=0||position>size+1)
            {
                Console.WriteLine("Invalid position");
                return;

            }
            if(position==1)
            {
                AddFirst(data);
                return;
            }
            if(position==size+1)
            {
                AddLast(data); return;
            }
            Node newNode = new Node(data, null);
            Node temp = head;
            int i = 1;
            while(i<position-1)
            {
                temp=temp.next;
                i++;
            }
            newNode.next = temp.next;
            temp.next=newNode;
            size++;

        }
    
        public int RemoveAnywhere(int position)
        {
            if(position<=0||position>size)
            {
                Console.WriteLine("Invalid position");
                return -1;
            }
            if(position==1)
            {
                return RemoveFirst();
            }
            if(position==size)
            {
                return RemoveLast();
            }
            Node temp = head;
            int i = 1;
            while(i<position-1)
            {
                temp= temp.next;
                i++;

            }
            int data=temp.next.data;// the value to be removed
            temp.next=temp.next.next;// skips the node in between
            size--;
            return data;

        }
    
    }
}
