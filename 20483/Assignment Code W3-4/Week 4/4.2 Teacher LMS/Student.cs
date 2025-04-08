using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_Teacher_LMS
{
    internal class StudentData
    {
        public static List<Student> Students = new List<Student>();
    }
    class StudentGPAComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y) //Sort students by GPA--High to low
        {
            return y.GPA.CompareTo(x.GPA); //flipped x and y to reverse the order--highest GPA will come out 
        }
    }
    class StudentIDComparer : IComparer<Student> //Sort students by Sid (Student ID)
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Sid.CompareTo(y.Sid);
        }
    }
    internal class Student
    {
        public int Sid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float GPA { get; set; }

        //Leaving following commented block for future reference
        ////private so not read by the grid...but also not read anywhere else. Remove block if unused by end
        //private string FullName //make FullName a readonly property, saw this in demo 5 Feb AM
        //{
        //    get { return $"{FirstName} {LastName}"; }
        //}

        // CONSTRUCTOR for initializing Student objects--easier. See bottom notes
        public Student(int sid, string firstName, string lastName, float gpa)
        {
            Sid = sid;
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;

        }

    }
}

/*Without constructor:
 * Student student = new Student();
 * student.Sid = 1;
 * student.FirstName = "Dave"....
 * And so on, for every student you make
 * 
 * 
 * With constructor:
 * Student student = new Student(1, "Dave", "Hancock", 3.5f)
 * 
 * 
 */