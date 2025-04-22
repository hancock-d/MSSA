using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string username;

        [RelayCommand]
        private async Task Login()
        {
            if (!string.IsNullOrWhiteSpace(Username))
            {
                await Application.Current.MainPage.DisplayAlert("Succes", $"Welcome, {Username}!", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a username", "Ok");
            }
        }
    }
}
