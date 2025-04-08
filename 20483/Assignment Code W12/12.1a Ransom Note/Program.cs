namespace _12._1a_Ransom_Note
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    internal class Program
    {
        ////===================12.1a Ransom Note
        ///LeetCode #383
        static bool RansomeNote(string ransomNote, string magazine)
        {
            Dictionary<char, int> magDict = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (magDict.ContainsKey(c))
                    magDict[c]++;
                else
                    //magDict.Add(c, 1);
                    magDict[c] = 1;
            }

            foreach (char c in ransomNote)
            {
                if (!magDict.ContainsKey(c) || magDict[c] == 0)
                {
                    return false;
                }
                magDict[c]--;
            }

            return true;
        }


        ////====================12.1b Linked List Palindrome
        ///LeetCode #234
        static Node ReverseNodes(Node head)
        {
            Node current = head;
            Node prev = null;
            Node next;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev; //(now the head)
        }

        static bool IsPalindrome(Node head)
        {
            if (head == null || head.next == null)
                return true;

            //find middle using slow and fast pointers
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next; //finds the middle node
                fast = fast.next.next; //finds the end node
            }

            Node reversedNodes = ReverseNodes(slow); //starts at second half of nodes
            Node originalNodes = head;

            while (reversedNodes != null)
            {
                if (originalNodes.data != reversedNodes.data)
                    return false;

                originalNodes = originalNodes.next;
                reversedNodes = reversedNodes.next;
            }
            return true;
        }

        static Node AddNodes(int[] data)
        {
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
            while (node != null)
            {
                Console.Write(" " + node.data);
                node = node.next;
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=========12.1a Ransom Note\n");
            string note1 = "a", mag1 = "b";
            string note2 = "aa", mag2 = "ab";
            string note3 = "aa", mag3 = "aab";

            Console.WriteLine($"Input: '{note1}'  and  '{mag1}' ");
            Console.WriteLine($"Output: {RansomeNote(note1, mag1)}");
            Console.WriteLine($"Input: '{note2}'  and  '{mag2}' ");
            Console.WriteLine($"Output: {RansomeNote(note2, mag2)}");
            Console.WriteLine($"Input: '{note3}'  and  '{mag3}' ");
            Console.WriteLine($"Output: {RansomeNote(note3, mag3)}");

            //Console.WriteLine("Input string #1");
            //var string1 = Console.ReadLine();
            //Console.WriteLine("Input string #2");
            //var string2 = Console.ReadLine();
            //Console.WriteLine($"Output: {RansomeNote(string1, string2)}");

            Console.WriteLine("\n=========12.1b Linked List Palindrome\n");
            
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(2);
            head.next.next.next = new Node(1);
            Console.Write("Input: ");
            PrintNodes(head);
            Console.WriteLine($"Output: {IsPalindrome(head)}");

            Node head2 = AddNodes(new int[] { 1, 2 });
            Console.Write("Input: ");
            PrintNodes(head2);
            Console.WriteLine($"Output: {IsPalindrome(head2)}");
        }
    }
}
