namespace Mod3EmployeeSystemDave
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Using Class Data (wrapper) to create test data
            Data.Employees.Add(new Employee() { EmployeeId = 101, FullName = "Jim Derry", Salary = 100000, Address = "NY", Dept = Department.Marketing });
            Data.Employees.Add(new Employee() { EmployeeId = 102, FullName = "Kelly Simpson", Salary = 110000, Address = "NC", Dept = Department.IT });

            Application.Run(new Form1());
        }
    }
}