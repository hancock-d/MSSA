namespace Mod5_Q_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customerNames = new Queue<string>();

            customerNames.Enqueue("Deepali");
            customerNames.Enqueue("Don");
            customerNames.Enqueue("Nathan");

            foreach (string customerName in customerNames)
            {
                Console.Write(customerName + " ");
            }

            Console.WriteLine("After Dequeue:");
            customerNames.Dequeue();
            foreach (string customerName in customerNames)
            {
                Console.Write(customerName + " ");
            }

            Q myq = new Q(10); //array size is 10
            myq.Enqueue(1); //queueing 1
            myq.Enqueue(2); //queueing 2
            myq.Enqueue(3); //queueing 3
            myq.Enqueue(4); //queueing 4

            myq.Display();

            myq.Dequeue(); //DQing 1
            myq.Dequeue(); //DQing 2
            myq.Dequeue(); //DQing 3
            myq.Dequeue(); //DQing 4, should be empty
            Console.WriteLine("After DQ");
            myq.Display();
            Console.ReadKey();
        }
    }
}
