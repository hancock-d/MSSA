using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7CodeFirstDemoDave.Models; //Add this folder
using System.ComponentModel.DataAnnotations;


namespace Mod7CodeFirstDemoDave.Models
{
    // MASTER TABLE (1 to many--1 department to many employees)
    public class Department //make public
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } //nullable
        public virtual ObservableCollectionListSource<Employee> Employees { get; set; }

    }
}
