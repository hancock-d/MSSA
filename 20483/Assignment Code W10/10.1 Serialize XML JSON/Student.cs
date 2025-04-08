using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Serialize_XML_JSON
{

    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public float GPA { get; set; }

        public Student(string name, string address, float gpa)
        {
            Name = name;
            Address = address;
            GPA = gpa;
        }

        public Student() { } //required for xml serialization
    }
}
