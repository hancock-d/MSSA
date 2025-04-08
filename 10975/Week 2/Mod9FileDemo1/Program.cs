using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //allows you to use all classes belonging to System.IO
//using System.Data.SqlClient;

//CREATING A BASIC TEXT FILE TO ADD DATA AND READ IT BACK

namespace Mod9FileDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare constant variable string called path. Any file created will go into that directory
            // @ allows you to use escape sequence  (or can use path="C:\\Files\\"
            const string path = @"C:\Files\";
            Console.WriteLine("Exploring File IO operations");
            Console.WriteLine("Enter a file name with .txt extension:");
            string filename = path + Console.ReadLine(); //pcad16.txt will get appended (strings get attached) to the path

            //StreamWriter can be associated with the file and write to the file
            StreamWriter writer = null; //null points to any file, not associated with any files
            try
            {
                if (!File.Exists(filename)) //!not operator--if file doesn't exist
                {
                    writer = File.CreateText(filename); //creates file
                    writer.WriteLine($"New file created at {DateTime.Now}");  //writer instead of Console writes to the file, not the console
                    Console.WriteLine("File created"); //indicates to user in console that the file was created

                }
                else //if file already exists
                {
                    File.AppendAllText(filename, $"New line appended at {DateTime.Now}"); //will append a new line to the file with new line appeneded
                    Console.WriteLine("File appended");
                }

            }
            catch (Exception ex) //always need at least 1 catch block with try
            {
                Console.WriteLine(ex.Message);
            }
            finally //contains mandatory code even though the exception does or does not occur
            {
                if (writer != null) //writer doesn't point to the file then-->???
                    writer.Close(); //if it's pointing to something, it will close???
            }


            Console.WriteLine("Reading contents from file...");
            //using block is used to create a scope for that variable or object and is automatically disposed of when
            //it comes out of the block (when the closing bracket is reached), it will dispose of the reader
            using (StreamReader reader = new StreamReader(filename)) //using streamreader with the filename association, it can read the contents from filename
            {
                string line;
                while ((line = reader.ReadLine()) != null) //!=null means will read each line while there is text on a line
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }
    }
}
