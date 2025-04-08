using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7OverloadingDemo
{
    //OVERLOADING: writing same named method within the same class but with different number of parameters or different type of parameters
    //OVERLOADING: within class
    //OVERLOADING: also called static polymorphism, happens at runtime. no inheritance
    //OVERRIDING: happens accross the classes in inheritance
    //static classes cannot be instantiated (unlike abstract)
    internal static class OutputFormatter //creating new class to format the output and put it on the screen
                                   //classes with only functions/methods...
                                   //Class with utility/functionality only, holds no data

    {
        //public void Test() //cannot have normal method (not static) in static class because it needs an instance member in the class
        //{

        //}
        private static void Test() //not allowing acces in client code, but can be called in the static methods. Won't see Test() method in OutputFormatter in main
        {

        }
        public static void DisplayName(string firstname)//by making it static, you can invoke it without creating an object of the class 
                                                        //non-static method, must create object of this class and then you can only invoke it
                                                        //static used when classes are utility classes or you want the function to invoke the method..?
                                                        //method name(sting-type of parameters firstname-list of parameters
        {
            Test();
            // 2 ways to do it
            //Console.WriteLine("Welcome {0}, enjoy the course! ", firstname); //display firstname in {0}, its argument will be filled by firstname (passing firstname into it)
            Console.WriteLine($"Welcome {firstname}, enjoy the course!");
        }
        public static void DisplayName(string firstname, string lastname) //overloaded method
                                                                          //same named method but overloaded by passing it 2 parameters instead of 1
        {
            Console.WriteLine($"Hello {firstname} {lastname}, welcome to the course");
        }
    }
    //class C:OutputFormatter //error here means you cannot inherit from static classes (internal static class OutputFormatter)
    //{

    //}
}

//pass firstname only, goes to first implementation of method
//pass firstname and lastname, goes to second implementation of method
//inheritance, instantiation, non-static methods not allowed