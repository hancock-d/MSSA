using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Test;

namespace Test //creating a new namespace just to make a new student structure to be used in the main method. To access this in the main method, type Test.Student (namespace.struct)
{
    public struct Student
    {

    }
}
*/

namespace Mod6StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PostalAddress postal = new PostalAddress(); //calling the struct without passing variables, or provide variables (overload it) and pass those variables
            //everything gets inherited from System.Object from .NET 
            //accessed postal address, created an object of postaladdress to access its properties
            PostalAddress myaddress = new PostalAddress(); //new by default calls the default constructure PostalAddress. New is required for initialization
            myaddress.HouseNumber = 27; //calling the set block automatically
            myaddress.StreetName = "Tideway Lane"; //set block getting called on the left side of the = sign; get block being called when on the right side (accessing, reading the values)
            myaddress.City = "Northport";
            myaddress.ZipCode = 11731;
            Console.WriteLine($" {myaddress.GetHashCode()} , {myaddress.GetType()}"); //GetType shows namespace.(?)variable type(?)
            //get
            Console.WriteLine($"Address is {myaddress.HouseNumber}, {myaddress.StreetName}, {myaddress.City}, {myaddress.ZipCode}");
            /* //client code--using the structure created
            Student student1 = new Student(); */


            PostalAddress youraddress = new PostalAddress(27, "Lincoln Street", "Elwood", "NY", 12121); //creating another representation of the PostalAddress in the memory on the stack, create the object bypassing the values provided
            Console.ReadKey();
        }
    }
}
