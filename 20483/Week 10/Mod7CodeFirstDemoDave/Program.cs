using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDemoDave.Data;

namespace Mod7CodeFirstDemoDave
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

            //CREATING instance of employeeContext
            Records.employeeContext = new EmployeeContext(); //initialize db for the first time (static record from records.cs is being instantiated in the main method)
            Records.employeeContext.Database.EnsureCreated(); //Configure and create tables to specification
            Records.employeeContext.Departments.Load();
            Records.employeeContext.Employees.Load();

            Application.Run(new Form1());
        }
    }
}