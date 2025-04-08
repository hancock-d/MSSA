using Mod7CodeFirstDemoDave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7CodeFirstDemoDave.Data; //Added this in so you don't have to use Data. all the time

namespace Mod7CodeFirstDemoDave.Services
{
    public class CRUD //public
    {
        public void AddRecord(Employee employee)
        {
            //Object getting added in dbset (local copy)
            Data.Records.employeeContext.Employees.Add(employee); //Employees is dbSet--adds a new employee to the dbSet
            Records.employeeContext.SaveChanges(); //reflects changes immediately onto server side. Took out Data.Records because added Using at top
        }

        public void DeleteRecord(int eid) //passing employee id you want to delete
        {
            var emp = Records.employeeContext.Employees.Find(eid); //find the employee you want to delete
            if (emp != null)
            {
                Records.employeeContext.Employees.Remove(emp);
                Records.employeeContext.SaveChanges();
            }
        }

        public void UpdateRecord(int id, Employee emp) //id of employee you want to update, emp contains updated information
        {
            var emptoupdate = Records.employeeContext.Employees.Find(id);
            if (emptoupdate != null)
            {
                emptoupdate.EmpId = emp.EmpId; //updating the employee's ID, name, salary, DepartmentId
                emptoupdate.Name = emp.Name;
                emptoupdate.Salary = emp.Salary;
                emptoupdate.DepartmentId = emp.DepartmentId;
                Records.employeeContext.SaveChanges();
            }
        }

        public Employee FindEmployee(int id)
        {
            return Records.employeeContext.Employees.Find(id);
        }

        public int GetMaxId()
        {
            return Records.employeeContext.Employees.Max(e => e.EmpId); //e is temp variable of Employee type and selecting just employee IDs for Max method--If yo said e.Salary you'd get max salary
        }

        public ICollection<Employee> GetEmployees() //ICollection can also be IList
        {
            return Records.employeeContext.Employees.ToList(); //return it back as a list so you can attach it to a grid or list, whatever display you have
        }

        public ICollection<Department> GetDepartment() //ICollection can also be IList
        {
            return Records.employeeContext.Departments.ToList();
        }
    }
}
