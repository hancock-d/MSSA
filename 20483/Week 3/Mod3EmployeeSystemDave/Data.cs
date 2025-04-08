using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EmployeeSystemDave
{
    //Wrapper--wraps around the data for sake of getting/giving? the access
    internal class Data //class holds the list of employees
    {
        public static List<Employee> Employees = new List<Employee>(); //creating a static list (static so there can only be 1, want it common/usable in all forms)
    }
}
