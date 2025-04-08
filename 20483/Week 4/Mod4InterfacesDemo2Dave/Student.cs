using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4InterfacesDemo2Dave
{

    class StudentGPAComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.GPA.CompareTo(y.GPA);
            // return y.GPA.CompareTo(x.GPA); //Switch x and y to reverse the order--will put GPA highest to lowest
        }
    }
    internal class Student : IComparable<Student>  //
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public int Age { get; set; }

        //Compare students by names first
        public int CompareTo(Student? other)
        {
            int val = String.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase); //compares name of this. student to other(next). student
            return val;

        }
    }
}
