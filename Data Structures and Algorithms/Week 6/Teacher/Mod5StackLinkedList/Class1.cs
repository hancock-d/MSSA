using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5StackLinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int val,Node next)
        {
            this.data = val;
            this.next = next;
        }
    }
    class StackLL:IEnumerable<Node>
    {
        Node top;
        int size;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public StackLL()
        {
            this.top = null;
            this.size = 0;

        }
        public bool IsEmpty()
        {
            return this.size == 0;
        }
        // same as addfirst, we are opening only 1 end which is front end to simulate LIFO
        public void Push(int  val)
        {
            Node newNode = new Node(val, null);
            if(IsEmpty())
            {
                this.top = newNode;
            }
            else
            {
                newNode.next = this.top;
                this.top = newNode;
            }
            size++;
        }
        // removefirst
        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            int val=top.data;
            top=top.next;
            size--;
            return val;

        }
        public int Peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return top.data;

        }
        public void Display()
        {
            if(IsEmpty() )
            {
                Console.WriteLine("Stack is empty");
              
            }
            Node temp = top;
            while( temp != null )
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }

        public IEnumerator<Node> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


}
