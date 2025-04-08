using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDemoDave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstDemoDave.Data
{
    public class EmployeeContext : DbContext  // this class (DbContext) represents the database in the server
    {
        ////Adding tables
        public DbSet<Department> Departments { get; set; } // Dbset = type, <Department> is a property, Departments is a collection(?)
        public DbSet<Employee> Employees { get; set; }
        ////add your server(?)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //protected method
        {
            // provide your own connection string
            optionsBuilder.UseSqlServer("data source=DAVE-G14;initial catalog=PCAD16Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        ////Add dummy records in the server
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData
                (
                new Department { DepartmentId = 1, DepartmentName = "HR" },
                new Department { DepartmentId = 2, DepartmentName = "Marketing" },
                new Department { DepartmentId = 3, DepartmentName = "Finance" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 101, Name = "Nathan", Salary = 60000, DepartmentId = 1 },
                new Employee { EmpId = 102, Name = "Fred", Salary = 80000, DepartmentId = 2 },
                new Employee { EmpId = 103, Name = "Alex", Salary = 90000, DepartmentId = 3 }
                );
        }

    }
}
