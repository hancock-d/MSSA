namespace LINQ_Demo2_Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ: Language Integrated Query
            //string query = "select * from Emp";


            int[] scores = { 23, 45, 12, 400, 355 }; //data source that you're filing a query on
            //Show all scores > 40
            // score is any temporary variable name, like a foreach loop
            // Type will be decided based on where it's getting data from (scores, int)
            var scoreresults = from score in scores
                               where score > 40 //condition, not required, a filter
                               select score;
            Console.WriteLine("Scores > 40");
            foreach (var item in scoreresults)
            {
                Console.WriteLine(item);
            }


            List<string> names = new List<string> { "Bill", "Alex", "James", "Rob" };
            // Find all names that start with A
            var result_A = from name in names
                           where name.StartsWith("A")
                           select name;

            /* //FORCED query execution, happens now
             * var result_A = (from name in names
                           where name.StartsWith("A")
                           select name).ToList(); //forced the query expression to happen now
            */

            //Add a name after the query--doesn't matter
            names.Add("Andrew");
            // DEFERRED query execution, only happens when being accessed
            Console.WriteLine("Names starting with A:");
            foreach (var item in result_A)
            {
                Console.WriteLine(item);
            }


            /* =======SYNTAX===========From-Where-Select
             * from name in collection
             *  where condition (optional)
             *  select name
             */

            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = [0, 1, 2, 3, 4, 5, 6];

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery = from num in numbers
                           where (num % 2) == 0 //finding even numbers, completely divisible by 2
                           select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
