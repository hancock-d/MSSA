using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(); //creating new instance of the class Student
            
            Console.WriteLine("Enter the first name of the student:"); //getting first name of student
            stud1.StudentFname = Console.ReadLine(); //setting stud1 last name
            Console.WriteLine("Enter the last name of the student:"); //getting last name
            stud1.StudentLname = Console.ReadLine(); //setting stud1 last name
            Console.WriteLine("What is your student ID#?");
            stud1.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("What grade did you receive?");
            stud1.StudentGrade = char.Parse(Console.ReadLine());
            
            Console.WriteLine($"\nStudent name: {stud1.StudentLname}, {stud1.StudentFname}");
            Console.WriteLine($"Student ID#: {stud1.StudentId}");
            Console.WriteLine($"Grade: {stud1.StudentGrade}");


            
            Student stud2 = new Student(); //creating new instance of class Student
            Console.WriteLine("\nEnter the first and last name of the student:");
            stud2.StudentFname = Console.ReadLine(); //How can I read both first and last name from the same line?
            stud2.StudentLname = Console.ReadLine(); //leaving it like this for visibility
            Console.WriteLine("What is your student ID#?");
            stud2.StudentId = int.Parse(Console.ReadLine());
            Console.WriteLine("What grade did you receive?");
            stud2.StudentGrade = char.Parse(Console.ReadLine());

            Console.WriteLine($"\nStudent name: {stud2.StudentLname}, {stud2.StudentFname}");
            Console.WriteLine($"Student ID#: {stud2.StudentId}");
            Console.WriteLine($"Grade: {stud2.StudentGrade}");
            
            Console.ReadKey();
        }
    }
}
