using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_Stack_With_Linked_List_Dave
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }
    }
    class StackLL
    {
        Node top;
        int size;
        public StackLL() //CONSTRUCTOR
        {
            this.top = null;
            this.size = 0;
        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        public void Push(int val) //same as addfirst, we are opening only 1 end, the front end, to simulate LIFO
        {
            Node newNode = new Node(val, null); //have to pass null because it's new and doesn't point to a next node (yet(?))
            if (IsEmpty())
            {
                this.top = newNode; //this.top starts pointing to the newNode
            }
            else
            {
                newNode.next = this.top; //same as mod4 linked list demo except it's top instead of head
                this.top = newNode;
            }
            size++;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            int val = top.data;
            top = top.next;
            size--;
            return val; //returning value back, which is popped
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return top.data;
            }
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is emptyy");
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
