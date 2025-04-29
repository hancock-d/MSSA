using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Models
{

    public static class UserSession
    {
        // This class stores user session data of current user
        public static User CurrentUser { get; set; }

        //public static string Username { get; set; }
        //public static string SquatMax { get; set; }
        public static string SelectedDay { get; set; }
    }
}
