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

        //only works for windows
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var projectFolderPath = @"C:\MSSA\PCAD16\Final Project\StrengthBuilder";

        //        if (!Directory.Exists(projectFolderPath))
        //        {
        //            Directory.CreateDirectory(projectFolderPath);
        //        }

        //        var dbPath = Path.Combine(projectFolderPath, "strengthBuilder.db3");

        //        optionsBuilder.UseSqlite($"Filename={dbPath}");
        //    }
        //}

        /// <summary>
        /// trying to path for android
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbPath = Path.Combine(FileSystem.AppDataDirectory, "strengthBuilder.db3");
                optionsBuilder.UseSqlite($"Filename={dbPath}");
            }
        }


        public AppDbContext()
        {
            Database.EnsureCreated();
        }
    }
}
