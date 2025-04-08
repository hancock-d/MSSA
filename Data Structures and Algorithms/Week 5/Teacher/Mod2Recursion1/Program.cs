namespace Mod2Recursion1
{
    internal class Program
    {

        static void PrintDirectoriesinDirectory(string path, int depth)
        {
            string[]directories= Directory.GetDirectories(path);
            foreach (string d in directories)
            {
                Console.WriteLine(d);
                if(depth>0)
                {
                    PrintDirectoriesinDirectory(d,depth-1);// recursive call

                }
            }
        }

        static void Main(string[] args)
        {
            const string path = @"C:\Training";
            string[]directories=Directory.GetDirectories(path);
            //foreach(string directory in directories)
            //{
            //    Console.WriteLine(directory);
            //    string[]subDirs = Directory.GetDirectories(directory);
            //    foreach(string subdir in subDirs)
            //    {
            //        Console.WriteLine(subdir);
            //        string[]subsubdirs= Directory.GetDirectories(subdir);

            //    }
            //}
            PrintDirectoriesinDirectory(path, 2);
            Console.ReadKey();

        }
    }
}
