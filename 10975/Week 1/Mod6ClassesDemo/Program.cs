using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(); //creating a new instance of the class
            Console.WriteLine("Enter the name of the emplyee:");
            emp1.Name = Console.ReadLine(); //setting the emp1 name
            Console.WriteLine("Enter hourly rate:");
            emp1.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked weekly?");
            emp1.WeeklyHours = float.Parse(Console.ReadLine());
            emp1.CalculateSalary(); //setting salary field by calling the method

            Console.WriteLine($"Emplyee with id# {emp1.Id} and name {emp1.Name} earned ${emp1.Salary}"); //getting emp 1 id, name, salary. Id is already set, Salary is calculated above then retrieved

            Employee emp2 = new Employee(); //creating a new instance of the class
            Console.WriteLine("Enter the name of the emplyee:");
            emp2.Name = Console.ReadLine();
            Console.WriteLine("Enter hourly rate:");
            emp2.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked weekly?");
            emp2.WeeklyHours = float.Parse(Console.ReadLine());
            emp2.CalculateSalary(); //calling the method and salary field will be set

            Console.WriteLine($"Emplyee with id# {emp2.Id} and name {emp2.Name} earned ${emp2.Salary}");

            Console.ReadKey();

        }
    }
}