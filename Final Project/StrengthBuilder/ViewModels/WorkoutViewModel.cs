using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using StrengthBuilder.Services;
using StrengthBuilder.Helpers;


namespace StrengthBuilder.ViewModels
{
    public partial class WorkoutViewModel : ObservableObject
    {
        public ObservableCollection<string> SquatSets { get; } = new ObservableCollection<string>();

        public string SelectedDayDisplay => $"Workout for {UserSession.SelectedDay}";
        public WorkoutViewModel()
        {
            LoadSquatSets();
        }

        public void LoadSquatSets()
        {
            SquatSets.Clear();
            var selectedDay = UserSession.SelectedDay;

            if (UserSession.CurrentUser != null)
            {
                int oneRepMax = UserSession.CurrentUser.SquatMax;
                var sets = WorkoutService.GetWorkoutForDay(selectedDay, oneRepMax);

                foreach (var set in sets)
                    SquatSets.Add(set);
            }
            else
                SquatSets.Add("No session active.");
        }

        /// Relay Commands
        [RelayCommand]
        private async Task GoBack()
        {
            await UserSession.GoBackAsync();
        }

        [RelayCommand]
        private async Task GoHome()
        {
            await UserSession.GoHomeAsync();
        }
    }
}