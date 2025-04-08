using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Address_Book_Dictionary
{
    enum PhoneType
    {
        Cell,
        Work,
        Home,
    }
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
        public string Address { get; set; }

    }
}