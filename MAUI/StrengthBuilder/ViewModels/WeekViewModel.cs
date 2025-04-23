using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace StrengthBuilder.ViewModels
{
    public partial class WeekViewModel : ObservableObject
    {
        public ObservableCollection<string> TrainingDays { get; set; } = new ObservableCollection<string>
        {
            "Day 1",
            "Day 2",
            "Day 3",
            "Day 4",
            "Day 5",
            "Day 6",
            "Day 7",
            "Day 8",
            "Day 9",
        };

        [ObservableProperty]
        private string selectedDay;

        //public string SquatInfo => $"Your squat max is {UserSession.SquatMax} lbs.";
        [RelayCommand]
        private async Task StartWorkout()
        {
            if (!string.IsNullOrWhiteSpace(SelectedDay))
            {
                UserSession.SelectedDay = SelectedDay;
                await Shell.Current.GoToAsync("//workout");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Select a Day", "Please pick a day", "Ok");
            }

        }
    }
}
