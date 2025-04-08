using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6ClassesDemo
{
    internal class Employee //internal means it can only be used in the same assembly (list of stuff in solution explorer)
    {
        // to share count with all employee objects
        static int count = 0; //done as static(global, common, can be accessed by all objects of that class) so you don't have to create the field over and over when creating multiple objects
        public Employee() //calling the constructor Employee in the class and increasing the employee id by 1
        {
            count++;
            this.id = count; //increasing employee id by 1
        }
        private int id;
        public int Id
        {
            get //setting the id automatically. makes it accessible
            {
                return this.id;
            }
        }
        public string Name { get; set; }
        public float HourlyRate { get; set; }
        public float WeeklyHours { get; set; }
        private decimal salary;
        public decimal Salary
        {
            get //makes it read only
            { return this.salary; } //this. specifically points to local variable (the private variable) that holds the salary which is a part of that class.
        }

        private void Deductions() //this function is private, client code cannot access the function
        {
            this.HourlyRate = this.HourlyRate - (this.HourlyRate * 5) / 100;
        }
        public decimal CalculateSalary()
        {
            Deductions();
            this.salary = Convert.ToDecimal(this.HourlyRate * this.WeeklyHours); //Convert.ToDecimal needed because salary is decimal and HourlyRate WeeklyHours are float
            return salary;
        }

    }
}
