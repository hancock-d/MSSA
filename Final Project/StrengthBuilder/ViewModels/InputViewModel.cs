using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Models;
using StrengthBuilder.Services;

namespace StrengthBuilder.ViewModels
{
    public partial class InputViewModel : ObservableObject
    {
        private readonly UserService _userService;

        //Dependecy injection for USerService (saves updates)
        public InputViewModel(UserService userService)
        {
            _userService = userService;
        }

        [ObservableProperty]
        private string squatMax;

        [RelayCommand]
        private async Task Continue()
        {
            if (!string.IsNullOrWhiteSpace(SquatMax))
            {
                if (UserSession.CurrentUser != null)
                {
                    if (int.TryParse(SquatMax, out int squatMaxValue))
                    {
                        // Update the current user's squat max
                        UserSession.CurrentUser.SquatMax = squatMaxValue;

                        // Save changes back to the database
                        await _userService.UpdateUserAsync(UserSession.CurrentUser);

                        // Navigate to the next page
                        await Shell.Current.GoToAsync("//week");
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid number for squat 1RM.", "Ok");
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "No active user session found.", "Ok");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your squat 1RM.", "Ok");
            }
        }
        //[RelayCommand]
        //private async Task DeleteUser()
        //{
        //    if (UserSession.CurrentUser == null)
        //    {
        //        await Shell.Current.DisplayAlert("Error", "No active user session found.", "Ok");
        //        return;
        //    }

        //    bool confirm = await Shell.Current.DisplayAlert("Confirm Deletion", "Are you sure you want to delete your account?", "Yes", "Cancel");

        //    if (!confirm)
        //        return;
        //    try
        //    {
        //        //delete user from db
        //        await _userService.DeleteUserAsync(UserSession.CurrentUser);
        //        //clear sessions
        //        UserSession.CurrentUser = null;
        //        Preferences.Remove("LoggedInUsername");

        //        await Shell.Current.GoToAsync("//login");
        //    }
        //    catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Error", $"Failed to delete user: {ex.Message}", "Ok");
        //    }
        //}

    }
}

