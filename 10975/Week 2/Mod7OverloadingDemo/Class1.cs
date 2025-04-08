using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7OverloadingDemo
{
    internal class A
    {
        //DYNAMIC POLYMORPHISM--needs inheritance. Across the classes
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; } //creating new property in class A for example in main
        }
        //Creating a new public virtual method
        public virtual void Method1() //virtual--logic can be changed/overridden if needed
        {
            Console.WriteLine("In method1 from class A");
        }
    }
    class B : A //new class B inheriting from A
    {
        public void Method2() //creating new method in class B for example in main
        { }
        public string Name { get; set; }     //creating new property in class B for example in main
        public override void Method1() //overriding method1
        {
            Console.WriteLine("In method1 from class B");
        }
    }
}
