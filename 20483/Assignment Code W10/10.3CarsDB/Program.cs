using _10._3CarsDB.Data;
using Microsoft.EntityFrameworkCore;

namespace _10._3CarsDB
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

            Inventory.carContext = new CarContext();
            Inventory.carContext.Database.EnsureCreated(); //Database is created!
            Inventory.carContext.Cars.Load();

            Application.Run(new Form1());
        }
    }
}