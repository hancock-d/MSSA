using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Models
{
    //represents a workout day and sets for that day
    public class WorkoutDay
    {
        public int Id { get; set; }
        public string DayName { get; set; } //"day 1, 2, 3..."
        public List<WorkoutSet> Sets { get; set; } = new List<WorkoutSet>();

    }
}
