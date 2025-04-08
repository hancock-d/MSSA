using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Student_Roster
{
    enum MonthOfAdmission
    {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }
    internal class Student
    {
        public int StudId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public char Grade { get; set; }
        public MonthOfAdmission Month {  get; set; }

    }
}
