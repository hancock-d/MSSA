using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Challenge_Student_Grade
{
    internal class Student
    {
        //--------------Create the student, adding properties for student details
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }


        //Constructor-initializes the student (object) when it is created.
        ///Has 5 parameters (id, name...) which provide initial values for the properties of the student object
        public Student(int id, string name, int mark1, int mark2, int mark3)
        {
            this.Id = id; //Assigns the parameter value "id" to the property "Id" from the class. Remember, reads right to left
            this.Name = name; //Left side Name refers to the property of the student object (this.Name implicitly). This is the data stored inside the object
            this.Mark1 = mark1; // Right side name/mark1 refers to the parameter passed to the constructor (taken from the readline)
            this.Mark2 = mark2; //Assigns the value of the parameter "mark2" to the property "Mark2" of the current object
            Mark3 = mark3; //don't have to use this., showing both for examples
        }

        // Method-Calculate total marks
        public int CalculateMarksTotal()
        {
        return Mark1 + Mark2 + Mark3;
        }

        //Method-calculate percentage
        public double CalculatePercent()
        {
            return (CalculateMarksTotal() / 3.0); 
        }

        //Method-determine grade
        public string DetermineGrade()
        {
            double percent = CalculatePercent(); //assigning percent as the number frm CalculatePercent method

            if (percent >= 90 && percent <= 100)
            {
                return "A";
            }
            else if (percent >= 80 && percent < 90)
            {
                return "B";
            }
            else if (percent >= 70 && percent < 80)
            {
                return "C";
            }
            else
            {
                return "Not good";
            }
        }

        //Method--display the details of stud: Id, name, individual Mark in (physics, chem, computer application), marks total, percent, grade value
        public void DisplayStud()
        {
            //Create variables to store the results of the methods
            int marksTotal = CalculateMarksTotal();
            double percent = CalculatePercent();
            string grade = DetermineGrade();

            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Marks in Physics: {Mark1}");
            Console.WriteLine($"Marks in Chemistry: {Mark2}");
            Console.WriteLine($"Marks in Computer Application: {Mark3}");
            Console.WriteLine($"Total Marks: {marksTotal}");
            Console.WriteLine($"Overall Percentage: {percent}%"); //How to truncate the percent to 2 decimal places?
            Console.WriteLine($"Average Overall Grade: {grade}");
        }

    }
}
