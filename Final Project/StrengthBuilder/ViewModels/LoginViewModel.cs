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

namespace StrengthBuilder.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        //store the injected service
        private readonly UserService _userService;



        [ObservableProperty]
        private string username;

        //Constructor injection
        public LoginViewModel(UserService userService)
        {
            _userService = userService;
        }

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
                    await Application.Current.MainPage.DisplayAlert("Sucees", $"First time in? Good luck, {Username}!", "Ok");
                    //UserSession.CurrentUser = newUser;

                }
                else
                {
                    userToSet = existingUser; //set session to existing user
                    await Application.Current.MainPage.DisplayAlert("Sucees", $"Welcome back, {Username}!", "Ok");
                    //UserSession.CurrentUser = existingUser;
                }
                //set the current user session
                UserSession.CurrentUser = userToSet;

                if (UserSession.CurrentUser != null)
                {
                    //Navigate to input page
                    //await Application.Current.MainPage.DisplayAlert("Success", $"Welcome, {Username}!", "Ok");
                    await Shell.Current.GoToAsync(nameof(InputPage));

                    Username = string.Empty;
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Unable to initialize user session.", "Ok");
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

            bool confirm = await Shell.Current.DisplayAlert("Confirm Deletion", "Are you sure you want to delete your account?", "Yes", "Cancel");

            if (!confirm)
                return;
            try
            {
                //delete user from db
                await _userService.DeleteUserAsync(UserSession.CurrentUser);
                //clear sessions
                UserSession.CurrentUser = null;
                Preferences.Remove("LoggedInUsername");

                await Shell.Current.GoToAsync("//login");
                Username = string.Empty;

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to delete user: {ex.Message}", "Ok");
            }
        }
    }
}