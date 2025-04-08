using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREATING NEW INSTANCE/OBJECT
            Student newStudent = new Student(); //creating new object "newStudent" calling class of Student
            Console.WriteLine("What is your first name?");
            newStudent.FirstName = Console.ReadLine();
            newStudent.LastName = "H";
            newStudent.Address = "WA";
            newStudent.Age = 37;
            newStudent.GPA = 3.8f;
            Console.WriteLine($"{newStudent.FirstName} living in {newStudent.Address} has a GPA of {newStudent.GPA}");
            //INVOKING FUNCTIONS
            newStudent.Communicate();
            newStudent.DoWork();
            newStudent.FollowSchedule();

            //CREATING NEW INSTANCE/OBJECT
            Instructor instructor = new Instructor(); //creating new object "instructor" calling class of Instructor
            instructor.FirstName = "Amy";
            instructor.Salary = 5000;
            Console.WriteLine($"{instructor.FirstName} has salary ${instructor.Salary}");
            instructor.FollowSchedule();
            instructor.DoWork();

            Console.ReadKey();
        }
    }
}
