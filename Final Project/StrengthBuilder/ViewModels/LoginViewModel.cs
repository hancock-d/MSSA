using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Models;
using StrengthBuilder.Services;

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
            if (!string.IsNullOrWhiteSpace(Username))
            {

                var existingUser = await _userService.GetUserByUsernameAsync(Username);

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
                }
                //Navigate to input page
                await Application.Current.MainPage.DisplayAlert("Success", $"Welcome, {Username}!", "Ok");
                await Shell.Current.GoToAsync("//input");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a username", "Ok");
            }
        }
    }
}


