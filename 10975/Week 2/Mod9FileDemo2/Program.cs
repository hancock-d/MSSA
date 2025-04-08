using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Mod9FileDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo(@"C:\"); //creating new obj drive of DriveInfo for the C:\ drive
            Console.WriteLine($"Drive name: {drive.Name}, drive size is:{drive.TotalSize}, free space is:{drive.TotalFreeSpace}");
            DirectoryInfo info = new DirectoryInfo(@"C:\"); //reads entire C:\ directory
            DirectoryInfo[] directories = info.GetDirectories(); //creating an array of directories, getdirectories returns an array
            foreach (DirectoryInfo d in directories) //d temporary variable
            {
                Console.WriteLine(d.Name + " " + d.CreationTime); //bring name of directory and when it was created
            }
            FileInfo[] fileInfos = info.GetFiles();

            foreach (FileInfo file in fileInfos)
            {
                Console.WriteLine(file.Name + " " + file.CreationTime);
            }

            Console.ReadKey();

        }
    }
}
