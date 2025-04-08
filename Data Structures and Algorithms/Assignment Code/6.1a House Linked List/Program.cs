namespace _6._1a_House_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houseList = new HouseLinkedList();

            houseList.AddLast(new House(101, "123 Main St", "Ranch"));
            houseList.AddLast(new House(102, "456 Oak Ave", "Colonial"));
            houseList.AddFirst(new House(100, "789 Pine Rd", "Victorian"));

            houseList.Display();
            Console.WriteLine();

            Console.Write("Enter House ID to search: ");
            int id = int.Parse(Console.ReadLine());


            House foundHouse = houseList.Search(id);
            if (foundHouse != null) //if foundhouse has data, print it
            {
                Console.WriteLine($"House found: ID {foundHouse.HouseId}, Address: {foundHouse.Address}, Type: {foundHouse.Type}");
            }
            else
                Console.WriteLine("House not found.");


        }
    }
}
