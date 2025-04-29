using Microsoft.EntityFrameworkCore;
using StrengthBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "strengthBuilder.db3");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
    }
}
