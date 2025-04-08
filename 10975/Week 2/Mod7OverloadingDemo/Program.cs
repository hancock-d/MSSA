using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7OverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A(); //CREATING NEW OBJECT A (objA) from CLASS A with Class A method -- A class to A class okay
            objA.Method1(); //Calling method from Class A
            B objB = new B(); //CREATING NEW OBJECT B (objB) from CLASS B with Class B method --- B class to B class okay
            objB.Method1(); //Calling method from class B
            A obj1 = new B(); //CREATING new obj1 from Class A but using method from Class B...Called Cross-referencing, dynamic polymorphism
                              //Obj1 has properties of class A but method of class B
                              //state of the object comes from A, invoking of methods comes from B if polymorphism/overriding is done
                              //state of object (variables/properties) is the left hand side, in this case it is from A
                              //You can invoke the method from child class as long as it is overridden, CROSS-REFERENCING/dynamic polymorphish is done.
                              //In this case from B
                              //"Down-Classing" from A to B, this is allowed
                              //A to B method okay
            //obj1.ID           //Can only see properties from class A, not class B (obj1.Name)
            //obj1.Method2()    //Cannot do this because it's still only calling properties from Class A, which does not have method2()
            obj1.Method1(); //obj1 from class A using method from B, which is overridden in class B to print "from class B"

            //B obj2 = new A(); //going from child class to base class. Cannot do that, because method is overridden in B. "Up-casting"
            //Cannot go from child to base class
            //Methods A to B is okay, B to A is not okay
            //B to A method not okay
            //UTILITY CLASS typically hold functions together and may not need to have states(properties, variables) to hold data
            //make the functions as static (don't need to create object in main)
            OutputFormatter.DisplayName("Dave"); //classname.method and passing hard-coded Dave into it in place of firstname
                                                 //can also pass firstname and lastname by choosing the down arrow from the overloaded version
            OutputFormatter.DisplayName("Dave", "Hancock"); //overloaded method passing Dave and Hancock into it

            //creating object of service class
            Service firstservice = new Service(); //if you have the serviceId, pass it. if you want to get it late, pass nothing
            firstservice.ServiceId = 1;
            firstservice.ServiceName = "Create";
            firstservice.StartService(1, "Create");
            Console.WriteLine($"is the service running {firstservice.IsRunning}"); //shows if service is running by printing true or false


            Console.ReadKey();
        }
    }
}
