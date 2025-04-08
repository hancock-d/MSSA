namespace _11._2b_Reverse_Singly_Linked_List
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int newData)
        {
            this.data = newData;
            this.next = null;
        }

        public Node(int newData, Node nextNode)
        {
            this.data = newData;
            this.next = nextNode;
        }
    }
    internal class Program
    {
        static Node ReverseList(Node head)
        {
            //set pointers--current, previous, next nodes
            Node current = head;
            Node previous = null;
            Node next;

            //traverse the nodes, as long as there is a node
            while (current != null)
            {
                //store next node of current node
                next = current.next;

                //reverse the current node's "next" pointer
                current.next = previous;

                //move the pointers down the line
                previous = current;
                current = next;
            }
            //previous should now be the head
            return previous;
        }

        static void PrintNodes(Node node)
        {
            while (node != null)
            {
                Console.Write(" " + node.data);
                node = node.next;
            }

        }
        static void Main(string[] args)
        {
            //hard-coded list of nodes 5-4-3-2-1
            Node head = new Node(5);
            head.next = new Node(4);
            head.next.next = new Node(3);
            head.next.next.next = new Node(2);
            head.next.next.next.next = new Node(1);
            //Node head = null; //not sure how to manage this

            Console.WriteLine("Original list: ");
            PrintNodes(head);
            Console.WriteLine();
            Console.WriteLine("Reversed list: ");
            Node reversed = ReverseList(head);
            PrintNodes(reversed);
        }
    }
}
