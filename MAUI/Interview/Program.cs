namespace Interview
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Where are you from, what country?");
            string country = Console.ReadLine().ToLower();

            //if (country == "USA" || country == "US" || country == "U.S.A" || country == "United States of America")
            var usAliases = new List<string> { "United States", "USA", "US", "U.S.A", "United States of America" };
            if (usAliases.Any(alias => alias.Equals(country, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Hello fellow American, {firstName} {lastName}");
            }
            else
                Console.WriteLine($"Hello, {firstName} {lastName} from {country}");
        }
    }
}


