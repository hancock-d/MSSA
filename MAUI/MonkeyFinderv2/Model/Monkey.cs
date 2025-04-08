using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinderv2.Model
{
    public class Monkey //make public
    {
        public string Name { get; set; }
        public string Location { get; set; }
         public string Details { get; set; }
        public string Image { get; set; } //string because it's a path
        public int Population { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
