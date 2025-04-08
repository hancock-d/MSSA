using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4b
{
    internal class Student
    {
        public Student()
        { } //I don't understand why I had to do this to make it work

        // creating private data members/properties
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        // creating public properties
        public int StudentId {  get; set; } //allows student ID to put input, set
        public string StudentFname { get; set; } //allows F name to be input, set
        public string StudentLname { get; set; } //allows L name to be input, set
        public char StudentGrade //I had to get help to make the letter upper case
        {
            get { return this.studentGrade; } //fetches their input, implicitly stores it in value
            set { studentGrade = char.ToUpper(value); } //changes their input to Upper case
        }
    }
}
