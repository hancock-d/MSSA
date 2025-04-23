using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrengthBuilder.Models;
using CommunityToolkit.Mvvm.Input;

namespace StrengthBuilder.ViewModels
{
    public partial class WorkoutViewModel : ObservableObject
    {

        public ObservableCollection<string> SquatSets { get; } = new ObservableCollection<string>();
        public string SelectedDay => UserSession.SelectedDay;

        public WorkoutViewModel()
        {
            LoadSquatSets();
        }

        private void LoadSquatSets()
        {
            if (int.TryParse(UserSession.SquatMax, out int oneRepMax))
            {
                SquatSets.Clear();

                //example workout with %s
                var percentages = new[] { 0.4, 0.6, 0.75, 0.85, 0.9 };
                var reps = new[] { "5 reps", "3 reps", "1 rep", "1 rep", "AMRAP" };

                for (int i = 0; i < percentages.Length; i++)
                {
                    int weight = (int)(oneRepMax * percentages[i]);
                    SquatSets.Add($"Squat {weight} lbs vs. {reps[i]}");
                }
            }
            else
            {
                SquatSets.Add("Invalid 1RM input.");
            }
        }
        [RelayCommand]
        private async Task GoBack()
        {
            await Shell.Current.GoToAsync("//week");
        }
    }
}
