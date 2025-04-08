namespace Mod4LinkedListdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region linkedlistclass
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(23);
            list.AddLast(34);
            list.AddLast(56);
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }

            list.AddFirst(11);
            Console.WriteLine("Updated list:");
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }
            // LinkedListNode<int> temp = new LinkedListNode<int>(23);
            // LinkedListNode<int> newnode = new LinkedListNode<int>(100);
            var temp = list.Find(23);
            if (temp != null)
            {
                list.AddBefore(temp, 100);
            }

            Console.WriteLine("Updated list:");
            foreach (int data in list)
            {
                Console.WriteLine(data);
            }

            #endregion   Console.ReadKey();

            Console.WriteLine("Custom linked list class");
          LList lList = new LList();
            lList.AddFirst(1);
            lList.AddFirst(2);
            lList.AddLast(3);
            lList.Display();
            lList.RemoveFirst();
            lList.Display();
            lList.AddLast(10);
            lList.Display();
            lList.RemoveLast();
            lList.Display();
            int found;

            if(lList.Search(3,out found))
            {
                Console.WriteLine("value found at index:" +  found);
            }
            else
            {
                Console.WriteLine("not found");
            }
            lList.AddAnywhere(2, 2);
            lList.AddAnywhere(0, 1);
            lList.Display();
            lList.RemoveAnywhere(2);
            lList.Display();

        Console.ReadKey();
        }
    }
}
