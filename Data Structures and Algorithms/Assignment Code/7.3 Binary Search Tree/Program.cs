namespace _7._3_Binary_Search_Tree
{
    internal class Program
    {


        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.InsertNode(100);
            tree.InsertNode(200);
            tree.InsertNode(20);
            tree.InsertNode(300);
            tree.InsertNode(10);
            tree.InsertNode(30);
            tree.InsertNode(150);

            Console.WriteLine("Tree in order");
            tree.InOrder(tree.Root);
            Console.WriteLine();
            //25 30 100 200

            Console.WriteLine("\nSearching for 25: ");
            var result1 = tree.Search(25);
            if (result1 != null)
            {
                tree.InOrder(result1);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Node not found");

            Console.WriteLine("\nSearching for 30: ");
            var result2 = tree.Search(30);
            if (result2 != null)
            {
                tree.InOrder(result2);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Node not found");

            Console.WriteLine("\nSearching for 100: ");
            var result3 = tree.Search(100);
            if (result3 != null)
            {
                tree.InOrder(result3);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Node not found");

            Console.WriteLine("\nSearching for 200: ");
            var result4 = tree.Search(200);
            if (result4 != null)
            {
                tree.InOrder(result4);
                Console.WriteLine();
            }
            else
                Console.WriteLine("Node not found");
        }
    }
}
