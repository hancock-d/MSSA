using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREATING NEW INSTANCE/OBJECT of chair
            Chair newChair = new Chair();
            newChair.NumberLegs = 4;
            newChair.Material = "Wood";
            newChair.Location = "Living room";
            //Invoking functions
            newChair.MyFunction();
//            Console.WriteLine($"I have {newChair.NumberLegs} legs, I am made of {newChair.Material}, and I am in the {newChair.Location}.");

            //CREATING NEW INSTANCE of table from table + furniture
            Table newTable = new Table();
            newTable.NumberLegs = 4;
            newTable.Material = "Glass";
            newTable.Location = "Kitchen";
            newTable.Surface = "Yes, I have a surface";
            newTable.Decorations = "I have flowers";
            //Invoking functions
            newTable.MyFunction();
 //           Console.WriteLine($"I have {newTable.NumberLegs} legs, am made of {newTable.Material}, and located in {newTable.Location}. {newTable.Surface} and {newTable.Decorations}");   

            //CREATING NEW INSTANCE of desk from desk + table
            Desk newDesk = new Desk();
            newDesk.NumberLegs = 4;
            newDesk.Material = "Metal";
            newDesk.Location = "Office";
            newDesk.Surface = "I also have a surface";
            newDesk.Decorations = "I have a computer";
            newDesk.Drawers = 2;
            //Invoking functions
            newDesk.MyFunction();
//           Console.WriteLine($"I have {newDesk.NumberLegs} legs, am made of {newDesk.Material}, and located in {newDesk.Location}. {newDesk.Surface}. {newDesk.Decorations} and {newDesk.Drawers} drawers.");  

            Console.WriteLine("\n\nPress any key to exit");

            Console.ReadKey();
        }
    }
}
