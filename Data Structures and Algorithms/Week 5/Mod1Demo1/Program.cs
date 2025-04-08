namespace Mod1Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document mydoc = new Document("My Resume", "Experience :"); //mydoc is an immutable object
            // mydoc.Content = "new content"; //Cannot do this because it is read only
            
            
            
            for (int j = 0; j <5; j++)
            {
                Console.WriteLine(j); //just print the number j
                if(j==4)
                {
                    // break; //exit the loop
                    continue; //go to the next j/value
                }
                Console.WriteLine(j);
            }

            int i = 10;
            while(i>10)
            {
                Console.WriteLine(i);
                i--;
            }
            do
            {
                // do this logic while...
            } while (i >= 0); //this condition is true. Will happen at least once
            Console.ReadKey();
            Console.WriteLine("Hello, World!");
        }
    }
}
