using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3_Call_Queue
{
    class Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }


        public Customer(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }
    }
    class Node
    {
        public Customer Data;
        public Node Next;

        public Node(Customer data)
        {
            Data = data;
            Next = null;
        }
    }

    class CallQueue
    {
        Node front;
        Node rear;
        int size; //checks how many elements are present/tracks # elements in Q

        public CallQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        //Check if Q is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(Customer customer)
        {
            Node newNode = new Node(customer);

            if (IsEmpty())
            {
                front = newNode; //front points to newNode, first element in Q
            }
            else
            {
                rear.Next = newNode; //otherwise, adding newNode after current rear. rear.next was previously null, now points to newNode

            }
            rear = newNode; //updating rear to point to newNode
            size++;
        }

        public Customer Dequeue() //have to return customer 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return null;
            }

            Customer data = front.Data;
            front = front.Next;
            size--;
            //now check if Q is empty after removing that customer
            if (IsEmpty())
            {
                rear = null; //rear points to nothing again
            }
            return data;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Q is empty");
                return; 
            }

            Node temp = front; //temporary node
            Console.WriteLine("Customers Queue'd: ");
            while (temp != null) //while temp node != null, keep incrementing it and keep printing it
            {
                //Console.WriteLine(temp.Data + " ");
                Console.WriteLine($"Name: {temp.Data.Name}, Phone: {temp.Data.PhoneNumber}");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        
        //Get count of customers in Q
        public int Count()
        {
            return size;
        }
    }
}
