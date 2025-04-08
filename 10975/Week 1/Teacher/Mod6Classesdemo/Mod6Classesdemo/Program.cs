using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Classesdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine("Enter the name of employee:");
            emp1.Name=Console.ReadLine();
            Console.WriteLine("Please enter hourlyrate:");
            emp1.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked?");
            emp1.WeeklyHours = float.Parse(Console.ReadLine());
            emp1.CalculateSalary();

            
            Console.WriteLine($"Employee with {emp1.Id} and name {emp1.Name} earned ${emp1.Salary}");

            Employee emp2 = new Employee();
            Console.WriteLine("Enter the name of employee:");
            emp2.Name = Console.ReadLine();
            Console.WriteLine("Please enter hourlyrate:");
            emp2.HourlyRate = float.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked?");
            emp2.WeeklyHours = float.Parse(Console.ReadLine());
            emp2.CalculateSalary();
            Console.WriteLine($"Employee with {emp2.Id} and name {emp2.Name} earned ${emp2.Salary}");

            Console.ReadKey();
        }
    }
}
