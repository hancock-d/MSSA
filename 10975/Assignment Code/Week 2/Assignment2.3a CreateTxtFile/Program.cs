using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //allows usage of IO classes belonging to the namespace System

namespace Assignment2._3a_CreateTxtFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOCATE the file
            //declare constant variable string called path. Any file created will go into that directory
            const string path = @"C:\Files\";
            Console.WriteLine("Enter a file name with a .txt extension:");
            string filename = path + Console.ReadLine(); //points to location of "path" and .txt file name

            //WRITE contents to the file
            StreamWriter writer = null; //initializing variable writer to null, references no objects. writer is just a placeholder
            try
            {
                if (!File.Exists(filename)) //if !filename does not exist
                {
                    writer = File.CreateText(filename); //creates a new document, assigns it to writer
                    writer.WriteLine($"Basic Details of user: "); //writes this to the file
                    Console.WriteLine("File created"); //writes this to the console

                    //Getting user input for basic details
                    Console.WriteLine("\nWhat is your name?");
                    string input = Console.ReadLine();
                    writer.WriteLine($"Name: {input}");
                    Console.WriteLine("What is your age?");
                    input = Console.ReadLine();
                    writer.WriteLine($"Age: {input}");
                    Console.WriteLine("What state do you live in?");
                    input = Console.ReadLine();
                    writer.WriteLine($"State: {input}");

                }
                else //if file already exists, appends the file with another line
                {
                    File.AppendAllText(filename, "New line added");
                    Console.WriteLine("File appended");
                }
            }
            catch (Exception ex) //at least 1 catch block required with try
            {
                Console.WriteLine(ex.Message); //error message that explains the reason for the error or an empty string ("")
            }
            finally //mandatory code, guaranteed to happen
            {
                if (writer != null) //if writer is being used...
                    writer.Close(); //close method closes resources(?) being used
            }


            //READ contents of the file
            Console.WriteLine("\nReading the contents from the file...");
            Console.WriteLine();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while((line = reader.ReadLine()) != null) //while there is text on a line, readline will read it
                {
                    Console.WriteLine(line); //writes the line read into the console
                }
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
