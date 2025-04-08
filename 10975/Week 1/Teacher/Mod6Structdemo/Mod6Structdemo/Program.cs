using Mod6Structdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Test;

//namespace Test
//{
//    public struct Student
//    {

//    }

        
//}

namespace Mod6Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            PostalAddress myaddress = new PostalAddress();
            Console.WriteLine($" {myaddress.GetHashCode()} , {myaddress.GetType()}");

            // created a object of postaladdress
           
            myaddress.HouseNumber = 27; //set
            myaddress.StreetName = "Tideway Lane";
            myaddress.City = "Northport";
            myaddress.ZipCode = 11731;
            Console.WriteLine($" {myaddress.GetHashCode()} , {myaddress.GetType()}");
            //get
            Console.WriteLine($"Address is {myaddress.HouseNumber}, {myaddress.StreetName} ,{myaddress.City}, {myaddress.ZipCode}");
            // client code
            // Student student1 = new Student();
            Console.WriteLine($" {myaddress.GetHashCode()} , {myaddress.GetType()}");

            PostalAddress youraddress = new PostalAddress(27, "lincoln street", "Elwood", "NY", 12121);
            Console.ReadKey();
        }
    }
}
