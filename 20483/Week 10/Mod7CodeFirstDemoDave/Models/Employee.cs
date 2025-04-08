using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstDemoDave.Models
{
    //CHILD TABLE
    public class Employee //made public
    {
        //What columns you want:
        [Key] //Add KEY attribute so EmpId is primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Asking db not to auto-generate, I will generate it
        public int EmpId { get; set; } //PK
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; } //should be foreign key, exactly same as DepartmentId from Department class
        public virtual Department Department { get; set; } // Relationship property, relating both tables (classes)

    }
}