using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Models;

namespace StrengthBuilder.ViewModels
{
    public partial class InputViewModel : ObservableObject
    {
        [ObservableProperty]
        private string squatMax;

        [RelayCommand]
        private async Task Continue()
        {
            if (!string.IsNullOrWhiteSpace(SquatMax))
            {
                //Store the squat max in the UserSession
                UserSession.SquatMax = SquatMax;

                //await Application.Current.MainPage.DisplayAlert("Saved", $"Squat 1RM: {SquatMax}", "Ok");
                //Navigate to WeekPage
                await Shell.Current.GoToAsync("//week"); // added the "//" to navigate to the root of the app shell then to the page
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a squat 1RM", "Ok");
            }
        }
    }
}
