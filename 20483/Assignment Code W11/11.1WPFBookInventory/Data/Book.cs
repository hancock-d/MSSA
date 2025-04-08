using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1WPFBookInventory.Data
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; } //Primary key, auto-generates next
        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
    }
}
