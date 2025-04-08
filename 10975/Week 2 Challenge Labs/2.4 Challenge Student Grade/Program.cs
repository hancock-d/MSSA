using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Challenge_Student_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get stud details from user
            Console.Write("Enter the student's ID number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter grade for Physics: ");
            int mark1 = int.Parse(Console.ReadLine());
            Console.Write("Enter grade for Chemistry: ");
            int mark2 = int.Parse(Console.ReadLine());
            Console.Write("Enter grade for Computer Application: ");
            int mark3 = int.Parse(Console.ReadLine());

            //Now create a new student object, passing the details to it
            Student student = new Student(id, name, mark1, mark2, mark3);

            //Run method to display the student's details
            student.DisplayStud(); //method being called on student object, accessing the student's properties
        }
    }
}
