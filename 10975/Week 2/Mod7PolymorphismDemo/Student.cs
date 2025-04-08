using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7PolymorphismDemo
{
    //CREATING NEW CHILD CLASS STUDENT FROM PARENT CLASS PERSON
    internal class Student:Person
    {
        public float GPA { get; set; }  
        //abstract-override (compulsion, have to provide logic)
        public override void FollowSchedule() //calling FollowSchedule method to be changed
        {
            Console.WriteLine("I am in virtual classroom 8 to 4 pst"); //providing some logic for the FollowSchedule method
        }
        //virtual-override (choice, don't have to provide new logic)
        public override void DoWork()
        {
            // base.DoWork(); //will call DoWork method from base class and write "I do some work"
            Console.WriteLine("I do C# assignment"); //can create your own logic. Commented out the original logic and made your own
        }
    }
}
