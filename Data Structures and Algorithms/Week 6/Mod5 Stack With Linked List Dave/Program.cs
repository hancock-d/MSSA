namespace Mod5_Stack_With_Linked_List_Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL mystack = new StackLL();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Display();
            Console.WriteLine("After pop");
            mystack.Pop(); //popping 3--LIFO
            mystack.Pop(); //popping 2
            mystack.Pop(); //popping 1, should be empty
            mystack.Display();
            Console.ReadKey();

        }
    }
}
