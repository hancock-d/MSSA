using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EmployeeSystemDave
{
    internal abstract class Person  //Person will be a base abstract class, WON'T BE CREATING OBJECTS OF PERSON CLASS but will be inheriting properties in employee class
    {
        public string? FullName { get; set; } //?makes the field nullable
        public string? Address { get; set; }
    }
}
