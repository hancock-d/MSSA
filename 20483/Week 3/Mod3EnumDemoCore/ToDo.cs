using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3EnumDemoCore
{
    enum Status //make an enum to represent status of program. These are the values I want to have as status
    {
        NotStarted=1,
        OnHold,
        InProgress,
        Completed,
        Dismissed
    }
    internal class ToDo
    {
        public int TaskId { get; set; } //get set auto properties
        public string ?Description { get; set; } //need a description for the class   ?means it can hold null value type, otherwise every instance of the class would have to have a description
        public float EstimatedHours { get; set; }
        public Status TaskStatus { get; set; } //public   valuetype status (enum)    Name
        
    }
}
