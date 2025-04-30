using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.Models;
using StrengthBuilder.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Helpers
{
    // class stores user session data of current user, just a static session
    public static class UserSession
    {
        public static User CurrentUser { get; set; }
        public static string SelectedDay { get; set; }

        public static async Task LogoutAsync()
        {
            if (CurrentUser == null)
            {
                await Shell.Current.DisplayAlert("Error", "No active user session found.", "Ok");
                return;
            }
            else
            {
                bool confirm = await Shell.Current.DisplayAlert("Logout", "Do you want to log out?", "Yes", "Cancel");

                if (!confirm)
                    return;
                else
                {
                    await ClearSession();
                }
            }
        }
        public static async Task ClearSession()
        {
            CurrentUser = null;
            SelectedDay = null;
            Preferences.Remove("CurrentUserId");
            await Shell.Current.GoToAsync(nameof(LoginPage));
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
            await Shell.Current.Navigation.PopAsync(); //pops the top path from the stack
        }
    }
}
