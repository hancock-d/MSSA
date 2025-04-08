namespace Mod3IndexerDemoDave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodMenu weekendMenu = new FoodMenu(new List<string> { "WeekendSpecial Sandwich", "WS Pizza", "WS Salad" }); //these items going to the list and being attached to internal private collection fooditems
            // weekendMenu[3] = "Burger";

            for (int i = 0; i < weekendMenu.Count; i++)
            {
                Console.WriteLine(weekendMenu[i]); //get this
            }

            Console.WriteLine("Add a new food item");
            weekendMenu[weekendMenu.Count] = Console.ReadLine();

            Console.WriteLine("Updated menu: ");
            for (int i = 0; i < weekendMenu.Count; i++)
            {
                Console.WriteLine(weekendMenu[i]); //get this
            }
            Console.ReadKey();
        }
    }
}
