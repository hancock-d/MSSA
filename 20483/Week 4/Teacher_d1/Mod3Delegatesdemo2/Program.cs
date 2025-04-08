namespace Mod3Delegatesdemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employees = new List <Employee> ();
          
            employees.Add(new Employee() { Eid = 1, Name="Nathan", YearsOfExp=2, Grade='A' });
            employees.Add(new Employee() { Eid = 2, Name = "Sherry", YearsOfExp = 6, Grade = 'B' });
            employees.Add(new Employee() { Eid = 3, Name = "Kelly", YearsOfExp = 8, Grade = 'A' });
            employees.Add(new Employee() { Eid = 4, Name = "Alex", YearsOfExp = 1, Grade = 'C' });
            employees.Add(new Employee() { Eid = 5, Name = "Peter", YearsOfExp = 5, Grade = 'B' });

            Console.WriteLine("List of employees:");
            foreach(var emp in  employees)
            {
                Console.WriteLine($"{emp.Name} , {emp.YearsOfExp} , {emp.Grade} ");
            }

            Console.WriteLine("Employees those can be promoted by grade:");
            PromoteEmployee(employees,PromotablebyGrade);// func name

            IsPromotable promotable = new IsPromotable(PromotablebyExp);
            Console.WriteLine("Employees those can be promoted by exp");
            PromoteEmployee(employees,promotable); // del 
            Console.ReadKey ();
        }

        static void PromoteEmployee(List <Employee> employees,IsPromotable isPromotable)
        {
            foreach(var emp in employees)
            {
                if(isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + " can be promoted!");
                }
            }
        }
        static bool PromotablebyGrade(Employee employee)
        {
            if (employee.Grade == 'A')
            {
                return true;
            }
            return false;
        }
        static bool PromotablebyExp(Employee employee)
        {
            if(employee.YearsOfExp>=5) return true;
            return false;
        }


    }
}
