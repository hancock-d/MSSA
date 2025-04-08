namespace Mod5StackLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL mystack=new StackLL();
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Display();
            Console.WriteLine("after pop");
            mystack.Pop();
            mystack.Pop();
            mystack.Pop();
            mystack.Display();
            Console.ReadKey();
        }
    }
}
