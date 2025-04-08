namespace _12._2_Remove_LL_Elements
{
    class Node
    {
        public int val;
        public Node next;

        public Node(int val)
        {
            this.val = val;
            this.next = null;
        }
    }
    internal class Program
    {
        ////===========12.2 Remove Linked List Elements
        ///LeetCode #203

        static Node RemoveNode(Node head, int val)
        {

            //if (head == null || head.val == val)
            //    head = head.next;
            while (head != null && head.val == val) //handles multiple head nodes == val
            {
                head = head.next;
            }

            Node current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                    current = current.next;
            }
            return head;
        }

        static Node AddNodes(int[] data)
        {
            if (data == null || data.Length == 0)
                return null;

            Node head = new Node(data[0]);
            Node current = head;

            for (int i = 1; i < data.Length; i++)
            {
                current.next = new Node(data[i]);
                current = current.next;
            }
            return head;
        }

        static void PrintNodes(Node node)
        {
            //if (node == null || node.val == 0)
            //    Console.Write("Node is null or 0");
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===========12.2 Remove Linked List Elements\n");

            Node input1 = AddNodes(new int[] { 1, 2, 6, 3, 4, 5, 6 });
            int val1 = 6;
            Console.Write("Input 1: ");
            PrintNodes(input1);
            Node result1 = RemoveNode(input1, val1);
            Console.Write("Output 1: ");
            PrintNodes(result1);

            Node input2 = AddNodes(new int[] { });
            int val2 = 1;
            Console.Write("Input 2: ");
            PrintNodes(input2);
            input2 = RemoveNode(input2, val2);
            Console.Write("Output 2: ");
            PrintNodes(input2);


            Node input3 = AddNodes(new int[] { 7, 7, 7, 7 });
            int val3 = 7;
            Console.Write("Input 3: ");
            PrintNodes(input3);
            input3 = RemoveNode(input3, val3);
            Console.Write("Output 3: ");
            PrintNodes(input3);
        }
    }
}
