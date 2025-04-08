using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2a
{
    //Creating Base class furniture with number of legs, material, and location in house
    internal abstract class Furniture
    {
        public abstract void MyFunction();
        public int NumberLegs { get; set; }
        public string Material {  get; set; }
        public string Location { get; set; }
    }
    
    //Creating derived class chair, additional properties none
    internal class Chair : Furniture
    {
        public override void MyFunction()
        {
            //throw new NotImplementedException();
            Console.WriteLine("I am a chair, there's nothing special about me");
            Console.WriteLine($"I have {NumberLegs} legs, I am made of {Material}, and I am in the {Location}.");
        }
        
    }

    //Creating derived class Table, additional properties surface, decorations
    internal class Table : Furniture
    {
        public string Surface { get; set; }
        public string Decorations { get; set; }
        public override void MyFunction()
        {
            //throw new NotImplementedException();
            Console.WriteLine("\nI am a table and am special because I have a surface and maybe decorations");
            Console.WriteLine($"I have {NumberLegs} legs, am made of {Material}, and located in the {Location}. {Surface} and {Decorations}");
        }

    }

    //Creating derived class Desk from Table, additional properties drawers
    internal class Desk : Table
    {
        public int Drawers { get; set; }
        public override void MyFunction()
        {
            //base.MyFunction(); //base. is referring to the Table class MyFunction()
            Console.WriteLine("\nI am a desk and am special because I might also have drawers");
            Console.WriteLine($"I have {NumberLegs} legs, am made of {Material}, and located in the {Location}. {Surface}. {Decorations} and {Drawers} drawers.");
        }

    }
}
