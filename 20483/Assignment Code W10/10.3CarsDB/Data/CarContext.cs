using _10._3CarsDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3CarsDB.Data
{
    public class CarContext : DbContext //DbContext represents the db in the server
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DAVE-G14;initial catalog=PCAD16Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { VIN = "AGSU1985", Make = "Subaru", Model = "Forester", Price = 40000, Year = 2021 },
                new Car { VIN = "FRON9753", Make = "Subaru", Model = "Crosstrek", Price = 35000, Year = 2022 },
                new Car { VIN = "PHYE6327", Make = "Subaru", Model = "Ascent", Price = 50000, Year = 2023 },
                new Car { VIN = "MNFI9347", Make = "Toyota", Model = "Highlander", Price = 55000, Year = 2024 },
                new Car { VIN = "PLDW6380", Make = "Toyota", Model = "RAV4", Price = 40000, Year = 2025 }
                );
        }
    }
}
