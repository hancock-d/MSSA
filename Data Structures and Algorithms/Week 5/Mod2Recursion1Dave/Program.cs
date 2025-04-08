namespace Mod2Recursion1Dave
{
    internal class Program
    {
        //DEMO WILL BE DOING A SIMPLE FUNCTION USING A FOR LOOP
        //THEN REPLACING THAT FOOR LOOP WITH A RECURSIVE FUNCTION

        static void PrintDirectoriesinDirectory(string path, int depth) //passing the path and depth given (how deep to go, number of times to call the function)
        {
            string[]directories = Directory.GetDirectories(path);
            foreach (string d in directories)
            {
                Console.WriteLine(d);
                if (depth > 0)
                {
                    PrintDirectoriesinDirectory(d, depth - 1); //recursive call--will go 1 level down and will come out of loop when depth hits 0
                }
            }
        }
        static void Main(string[] args)
        {
            const string path = @"C:\Files";
            string[] directories = Directory.GetDirectories(path);
            //foreach (string directory in directories)
            //{
            //    Console.WriteLine(directory);
            //    string[] subDirs = Directory.GetDirectories(directory);
            //    foreach (string subdir in subDirs)
            //    {
            //        Console.WriteLine(subdir);
            //        string[] subsubdirs = Directory.GetDirectories(subdir);

            //    }
            //}
            PrintDirectoriesinDirectory(path, 1);
            Console.WriteLine("Going deeper");
            PrintDirectoriesinDirectory(path, 2); //just going farther into the sub-directories
        Console.ReadKey();
        }
    }
}
