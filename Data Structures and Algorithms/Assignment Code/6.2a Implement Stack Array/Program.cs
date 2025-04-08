namespace _6._2a_Implement_Stack_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> newStack = new StackArray<int>(5);
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6); //stack maxed, show is full

            newStack.Display();

            newStack.Pop(); //pop 5
            newStack.Display();

            newStack.Pop(); //4
            newStack.Pop(); //3

            newStack.Peek();


            newStack.Pop(); //2
            newStack.Pop(); //1
            newStack.Pop(); //seeing what happens

            newStack.Peek();

            newStack.Display(); //should show empty stack
        }
    }
}
