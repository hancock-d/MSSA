namespace Mod5StackArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
          Stack<string>operations = new Stack<string>();
            StackArray mystack = new StackArray(10);
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
            mystack.Display();
            mystack.Pop();
            mystack.Display();
            mystack.Pop();
            mystack.Pop();
            mystack.Pop();
            mystack.Pop();
            mystack.Pop();
            mystack.Display();
            Console.ReadKey();
        }
    }
}
