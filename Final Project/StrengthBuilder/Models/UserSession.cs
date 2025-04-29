using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Models
{
    // class stores user session data of current user
    public static class UserSession
    {
        public static User CurrentUser { get; set; }
        public static string SelectedDay { get; set; }

        public static async Task LogoutAsync()
        {
            bool confirm = await Shell.Current.DisplayAlert("Logout", "Do you want to log out?", "Yes", "Cancel");

            if (!confirm)
                return;
            else
            {
                CurrentUser = null;
                Preferences.Remove("LoggedInUsername");
                await Shell.Current.GoToAsync(nameof(LoginPage));
            }
        }
        public static async Task GoHomeAsync()
        {
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        public static async Task GoInputAsync()
        {
            await Shell.Current.GoToAsync(nameof(InputPage));
        }
        public static async Task GoBackAsync()
        {
            await Shell.Current.Navigation.PopAsync(); //pops the top pack from the stack
        }
    }
}
