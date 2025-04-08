using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1WPFBookInventory.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated(); //create database
        }

        public DbSet<Book> Books { get; set; } //Create table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder);
        }

        private Book[] GetBooks()
        {
            return new Book[]
            {
                new Book { ISBN = 1001, Title = "The Three-Body Problem", Author = "Cixin Liu", Copies = 3 },
                new Book { ISBN = 1002, Title = "The Day of the Jackal", Author = "Frederick Forsyth", Copies = 1 },
                new Book { ISBN = 1003, Title = "The North Water", Author = "Ian McGuire", Copies = 6 },
                new Book { ISBN = 1004, Title = "Red Rising", Author = "Pierce Brown", Copies = 10 },
                new Book { ISBN = 1005, Title = "Snow Crash", Author = "Neal Stephenson", Copies = 2 }
            };

        }
    }
}
