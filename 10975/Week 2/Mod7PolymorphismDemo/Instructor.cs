using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7PolymorphismDemo
{
    internal class Instructor:Person
    {
        public double Salary { get; set; } //adding new Salary field to instructor (like GPA for student)
        public override void FollowSchedule() //*override then choose the method you want to override
        {
            // throw new NotImplementedException(); //default override coding, will just throw this exception
            Console.WriteLine("I teach from 8 to 4 pst"); //adding new override instructions
        }
        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("I teach, grade students");
        }
    }

    //CREATING NEW CLASS USING INSTRUCTOR AS PARENT CLASS--multi-level inheritance
    class ParttimeInstructor : Instructor
    {
        public override void FollowSchedule() //changes FollowSchedule method to mean the parttime instructor needs
        {
            Console.WriteLine("I conduct labs from 2 to 4 pst");
        }
        public override void DoWork()
        {
            Console.WriteLine("I check lab work");
        }

    }
}
