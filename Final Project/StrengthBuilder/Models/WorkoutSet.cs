using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Models
{
    public class WorkoutSet
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Reps { get; set; }
        public bool IsAmrap { get; set; }
        public bool IsWarmup { get; set; }
        public bool IsCompleted { get; set; }
    }
}
