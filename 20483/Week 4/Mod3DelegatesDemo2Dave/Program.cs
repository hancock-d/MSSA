namespace Mod3DelegatesDemo2Dave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); //create a list of employees <data type> name 

            employees.Add(new Employee() { Eid = 1, Name = "Nathan", YearsOfExp = 2, Grade = 'A' }); //Test/dummy data
            employees.Add(new Employee() { Eid = 2, Name = "Sherry", YearsOfExp = 6, Grade = 'B' });
            employees.Add(new Employee() { Eid = 3, Name = "Kelly", YearsOfExp = 8, Grade = 'A' });
            employees.Add(new Employee() { Eid = 4, Name = "Alex", YearsOfExp = 1, Grade = 'C' });
            employees.Add(new Employee() { Eid = 5, Name = "Peter", YearsOfExp = 5, Grade = 'B' });

            Console.WriteLine("List of employees: ");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name} , {emp.YearsOfExp} , {emp.Grade}");
            }

            Console.WriteLine("Employees that can be promoted by grade: ");
            PromoteEmployee(employees, PromotableByGrade);  //passing the method name itself as the logic
            //OR
            IsPromotable promotable = new IsPromotable(PromotableByExp); //passing delegate name
            Console.WriteLine("Employees that be promoted by experience: ");
            PromoteEmployee(employees, promotable); //employees here is passing the list, and delegate name

            Console.ReadKey();

        }


        //Function to take in IsPromotable delegate
        static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable)
        {
            foreach (var emp in employees)
            {
                if (isPromotable(emp))
                {
                    Console.WriteLine(emp.Name + " can be promoted!");
                }
            }
        }
        static bool PromotableByGrade(Employee employee)
        {
            if (employee.Grade == 'A')
                return true;
            return false;
        }
        static bool PromotableByExp(Employee employee)
        {
            if (employee.YearsOfExp >= 5) return true;
            return false;
        }

        //Can also write a functiont that considers both grade and years of exp
    }
}
