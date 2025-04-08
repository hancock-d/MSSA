namespace Mod4GenericsDemo1Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * List
             * Q--FIFO (First In, First Out)
             * Stack--LIFO (Last In, First Out)
             * Dictionary
             * SortedDictionary
             * 
             */

            //Stacks are Last In, First Out (LIFO) . Can create stack of any type
            Stack<int> intstack = new Stack<int>();

            Queue<string> customerQ = new Queue<string>();
            customerQ.Enqueue("Alex"); //Add Alex to the Queue
            customerQ.Dequeue(); //Remove Alex from the Queue

            Dictionary<string, string> Recipes = new Dictionary<string, string>(); //string is the Key, string is the value. Can be any data type
            Recipes.Add("Clear Soup", "1. Boil broth..."); //clear soup is key, boil broth is the value
            Recipes.Add("Fried Chicken", "1. Clean chicken...");

            //iterate through it
            foreach (var key in Recipes.Keys)
            {
                Console.WriteLine(key + "-" + Recipes[key]); //recipes of [clear soup] = boil broth...then recipes of [fried chicken] = clean chicken
            }
            
            Recipes.ContainsKey("Clear Soup"); //Check if you have fried chicken recipe already, will pass true or false
            Recipes.Remove("Clear Soup"); //will remove the value entireliy, including the key

            // Adding object of the entire person as the value
            Dictionary<string, Person>phoneBook = new Dictionary<string, Person>();
            if(phoneBook.ContainsKey("Deepali")) //Check if Key(person) already exists
            {
                Console.WriteLine("Person already exists");
            }
            else
            {
                //This data will come from the textbox in windows forms. Deepali will be the Key name, the rest will be the value
                phoneBook.Add("Deepali", new Person() { FirstName = "Deepali", LastName = "K", HomePhone = 8675309 });
            }

        }
    }
}
