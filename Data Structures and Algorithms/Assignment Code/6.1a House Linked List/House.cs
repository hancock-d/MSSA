using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1a_House_Linked_List
{
    class House
    {
        public int HouseId;
        public string Address;
        public string Type;

        public House(int houseId, string address, string type)
        {
            this.HouseId = houseId;
            this.Address = address;
            this.Type = type;

        }
    }
    class HouseNode
    {
        public House Data; //Data stores the house object
        public HouseNode Next; //points to the next node in the list

        public HouseNode(House data)
        {
            this.Data = data; //storing house object in the node
            this.Next = null; //initially, not pointing anywhere
        }
    }

    class HouseLinkedList
    {
        private HouseNode head; //first node in list
        private HouseNode tail; //last node in list
        private int size; //tracks number of nodes
        public int Size
        {
            get { return size; }
        }
        public HouseLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void AddFirst(House house)
        {
            HouseNode newNode = new HouseNode(house);
            if (IsEmpty())
            {
                this.head = newNode; //head points to this node
                this.tail = newNode; //tail points to this new node
            }
            else
            {
                newNode.Next = this.head; //next pointer of newNode points to current head
                this.head = newNode; //updating so head points to the newnode
            }
            size++;
        }

        public void AddLast(House house)
        {
            HouseNode newNode = new HouseNode(house); //wraps the house object inside a new node
            if (IsEmpty())
            {
                this.head = newNode; //same as addfirst--this node is the head
                this.tail = newNode;  //this node is tail
            }
            else
            {
                this.tail.Next = newNode; //link new node (tail) to previous last node

            }
            this.tail = newNode; //update tail to point to new last node
            this.size++;
        }

        public House Search(int id)
        {
            HouseNode temp = head;
            while (temp != null)
            {
                if (temp.Data.HouseId == id)
                {
                    return temp.Data; //return House obj if found
                }
                temp = temp.Next; //move temp to the next node
            }
            return null;
        }


        public void Display()
        {
            HouseNode temp = head;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine("House List:");
                while (temp != null)
                {
                    Console.WriteLine($"ID: {temp.Data.HouseId}, address: {temp.Data.Address}, Type: {temp.Data.Type}");
                    temp = temp.Next;
                }
            }
        }
    }
}
