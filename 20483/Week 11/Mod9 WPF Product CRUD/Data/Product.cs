using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_WPF_Product_CRUD.Data
{
    public class Product //make product
    {
        public int Id { get; set; } //Key automatically attached to first property
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }
    }
}
