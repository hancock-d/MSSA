namespace Mod8_Binary_Search_Tree_Demo_Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree(); //creating new BST class that holds all the methods too
            tree.InsertNode(tree.root, 100); //tree.root = root node, 100 is value wanted to add
            tree.InsertNode(tree.root, 200);
            tree.InsertNode(tree.root, 20);
            tree.InsertNode(tree.root, 300);
            tree.InsertNode(tree.root, 10);
            tree.InsertNode(tree.root, 30);
            tree.InsertNode(tree.root, 150);

            Console.WriteLine(tree.Search(300)); //will give value true or false

            Console.WriteLine("In-Order Traversal");
            tree.InOrderTraversal(tree.root);
            Console.WriteLine();

            Console.WriteLine("Pre-Order Traversal");
            tree.PreOrderTraversal(tree.root);
            Console.WriteLine();

            Console.WriteLine("Post-Order Traversal");
            tree.PostOrderTraversal(tree.root);
            Console.WriteLine();


        }
    }
}
