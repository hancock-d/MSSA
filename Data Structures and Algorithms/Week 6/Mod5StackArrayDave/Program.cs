namespace Mod5StackArrayDave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<string> operations = new Stack<string>();
            StackArray mystack = new StackArray(10);
            mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);
            mystack.Display();
            mystack.Pop(); //pops 5
            mystack.Display();
            mystack.Pop(); //pops 4
            mystack.Pop(); //pops 3
            mystack.Pop(); //pops 2
            mystack.Pop(); //pops 1
            mystack.Pop(); //just to see error or if it's getting handled properly
            mystack.Display(); //will show stack is empty because everything is popped out
            Console.ReadKey();
        }
    }
}
