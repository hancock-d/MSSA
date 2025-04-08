using Microsoft.EntityFrameworkCore; //gets added after inheriting frm DbContext
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_WPF_Product_CRUD.Data
{
    public class ProductContext : DbContext //public, database we created
    {
        //Constructor Base = base class constructor (db....
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            Database.EnsureCreated(); //Create the database
        }
        //Create the table with Product as the model class. Products is your property name or collection name
        public DbSet<Product> Products { get; set; } //Table getting created, used for CRUD operations

        protected override void OnModelCreating(ModelBuilder modelBuilder) //cannot be accessed outside the class
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        private Product[] GetProducts() //Dummy data with helper method to return new product array
        {
            return new Product[]
            {
                new Product{Id =1, Name = "Laptop", Description = "HP", Price = 900, Units = 3},
                new Product{Id =2, Name = "Speaker", Description = "Jabra", Price = 300, Units = 2},
                new Product{Id =3, Name = "Monitor", Description = "Dell 34 inches", Price = 200, Units = 1},
                new Product{Id =4, Name = "Webcam", Description = "HP", Price = 150, Units = 5},

            };
        }
    }
}
