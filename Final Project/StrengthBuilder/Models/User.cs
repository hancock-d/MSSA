using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Models
{
    //db model for saved users
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public int SquatMax { get; set; }

        //public int DeadliftMax { get; set; }
        //public int BenchMax { get; set; }
        //public int OverheadMax { get; set; }
    }
}
