using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7PolymorphismDemo
{
    //abstract class serves as a base template but cannot be instantiated (cannot create an instance/object of the person)
    //we write the abstract classes to build class hierarchy and not allow object creation (instantiation)
    internal abstract class Person //marking class as abstract, cannot make an object "Person"
    {
        private string firstName;
        //auto properties always create their own private backing fields
        public string FirstName
        {
            //get block helps to change the way the data is returned
            get
            {
                return this.firstName.ToUpper();
            }
            //set block will have a value assigned to the variable
            set //set the value, can also add validation logic.
            {
                if (value.Length <= 50) //value is the information you're sending to the
                {
                    this.firstName = value;
                }
                else
                {
                    //trim the value and make it fit in 50 characters
                }

            }
        }
        public string LastName { get; set; }//auto property
        //public int Age { get; set; }
        public int Age
        {
            get
            {
                return this.Age;
            }
            set
            {
                this.Age = value;
            }
        }
        public string Address { get; set; }
        public void Communicate() //this method would be common for all Persons
        {
            Console.WriteLine("I use a language to communicate!");
        }
        //normal classes can have virtual methods
        //virtual functions allow to change the functionality if needed in the derived classes
        //polymorphism
        public virtual void DoWork() //virtual method may or may not be altered in derived class, your choice
        {
            Console.WriteLine("I do some work");
        }
        //abstract methods/functions only belong to abstract classes
        //you must implement (provide logic to) the abstract method in derived class
        public abstract void FollowSchedule(); //abstract method will have to provide logic in the derived class
        //normal classes = instance classes : those which can be instantiated/creating an object from

    }
}
