using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EmployeeSystemDave
{
    enum Department
    {
        IT=1,
        Finance,
        HR,
        Marketing,
    }
    internal class Employee : Person //Employee class *inherits* from Person = has all properties and methods of Person
    {
        //These are properties of employee class that inherits from person class
        public int EmployeeId { get; set; } //EmployeeId property, not field
        public double Salary { get; set; } //Salary property, not field
        public Department  Dept { get; set; }
    }
}
