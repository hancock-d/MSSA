namespace _6._3_Call_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallQueue callQueue = new CallQueue();

            //Adding customers
            callQueue.Enqueue(new Customer("Dave", "555-0661"));
            callQueue.Enqueue(new Customer("Frankie", "555-1708"));
            callQueue.Enqueue(new Customer("Lindsey", "555-5840"));
            callQueue.Enqueue(new Customer("Jenny", "867-5309"));

            //Showing customers/queue and count 
            callQueue.Display();

            //Showing # of customers in Q
            Console.WriteLine($"Customers left in Queue: {callQueue.Count()}");


            //Dequeue customers
            Console.WriteLine("Serving first customer");
            callQueue.Dequeue();

            Console.WriteLine();
            //show customers again
            callQueue.Display();

            callQueue.Dequeue();
            callQueue.Dequeue();
            callQueue.Dequeue();
            callQueue.Dequeue(); //should be empty

            callQueue.Display();

            Console.ReadKey();

        }
    }
}
