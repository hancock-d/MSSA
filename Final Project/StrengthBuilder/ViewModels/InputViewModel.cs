﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Services;
using StrengthBuilder.Helpers;

namespace StrengthBuilder.ViewModels
{
    public partial class InputViewModel(UserService userService) : ObservableObject
    {
        private readonly UserService _userService = userService;
        [ObservableProperty]
        private string squatMax;


        [RelayCommand]
        private async Task Confirm()
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
                        await Shell.Current.GoToAsync(nameof(WeekPage));
                    }
                    else
                        await Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid number for your 1 rep max.", "Ok");
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Error", "No active user session found.", "Ok");
            }
            else
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter your 1 rep max.", "Ok");
        }

        
        [RelayCommand]
        private async Task GoHome()
        {
            await UserSession.GoHomeAsync();
        }

        public void LoadCurrentSquatMax()
        {
            if (UserSession.CurrentUser != null && UserSession.CurrentUser.SquatMax > 0)
                SquatMax = UserSession.CurrentUser.SquatMax.ToString();
            else
                SquatMax = string.Empty;
        }
    }
}


