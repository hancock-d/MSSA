using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Models;
using StrengthBuilder.Services;
using StrengthBuilder.View;
using StrengthBuilder.Helpers;

namespace StrengthBuilder.ViewModels
{
    public partial class LoginViewModel(UserService userService) : ObservableObject
    {
        
        private readonly UserService _userService = userService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private bool canDeleteUser = false;

        //Login and registration method
        [RelayCommand]
        private async Task Login()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a username", "Ok");
                return;
            }

            try
            {
                var existingUser = await _userService.GetUserByUsernameAsync(Username);
                User userToSet; //this will be the user to set in the session

                //check if user already exists
                if (existingUser == null)
                {
                    //If not, create new user
                    var newUser = new User
                    {
                        Username = Username,
                        SquatMax = 0
                    };

                    await _userService.AddUserAsync(newUser);
                    userToSet = newUser; //Set the current user session to newUser
                    await Application.Current.MainPage.DisplayAlert("Success", $"First time in? Good luck, {Username}!", "Ok");
                }
                else
                {
                    userToSet = existingUser; //set session to existingUser
                    await Application.Current.MainPage.DisplayAlert("Success", $"Welcome back, {Username}!", "Ok");
                }

                UserSession.CurrentUser = userToSet;
                Preferences.Set("CurrentUserId", userToSet.Id);

                if (UserSession.CurrentUser != null)
                {
                    await Shell.Current.GoToAsync(nameof(InputPage));
                    Username = string.Empty;
                }

            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the login process
                await Application.Current.MainPage.DisplayAlert("Error", $"An error occurred: {ex.Message}", "Ok");
            }
        }

        [RelayCommand]
        private async Task DeleteUser()
        {
            if (UserSession.CurrentUser == null)
            {
                await Shell.Current.DisplayAlert("Error", "No active user session found.", "Ok");
                return;
            }

            bool confirm = await Shell.Current.DisplayAlert("Confirm Deletion", $"Are you sure you want to delete your account, {UserSession.CurrentUser.Username}?", "Yes", "Cancel");

            if (!confirm)
                return;
            try
            {
                await _userService.DeleteUserAsync(UserSession.CurrentUser);
                await UserSession.ClearSession();

                Username = string.Empty;

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to delete user: {ex.Message}", "Ok");
            }
        }

        [RelayCommand]
        private async Task Logout()
        {
            await UserSession.LogoutAsync();
        }
    }
}