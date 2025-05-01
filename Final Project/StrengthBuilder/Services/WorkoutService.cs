using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthBuilder.Services
{
    //generates the workout sets for a given training day
    public static class WorkoutService
    {
        public static int RoundToNearestFive(double value)
        {
            return (int)(Math.Round(value / 5.0) * 5);
        }

        public static List<string> GetWorkoutForDay(string day, int oneRepMax)
        {
            var sets = new List<string>();

            void AddWarmupSets()
            {
                sets.Add($"1x5 @ {RoundToNearestFive(oneRepMax * 0.4)}#");
                sets.Add($"1x3 @ {RoundToNearestFive(oneRepMax * 0.5)}#");
            }

            switch (day)
            {
                case "Day 1": //3x5 65-75-85%, days 1, 4, 7
                case "Day 4":
                case "Day 7":
                    AddWarmupSets();
                    sets.Add($"1x5 @ {RoundToNearestFive(oneRepMax * 0.60)}# \t(60%)"); //working
                    sets.Add($"1x5 @ {RoundToNearestFive(oneRepMax * 0.70)}# \t(70%)"); //working
                    sets.Add($"1x5 @ {RoundToNearestFive(oneRepMax * 0.80)}# \t(80%)"); //working
                    sets.Add($"1xAMRAP @ {RoundToNearestFive(oneRepMax * 0.50)}#"); //empty the tank
                    break;
                case "Day 2": //3x3 70-80-90%, days 2, 5, 8
                case "Day 5":
                case "Day 8":
                    AddWarmupSets();
                    sets.Add($"1x3 @ {RoundToNearestFive(oneRepMax * 0.65)}# \t(65%)"); //working
                    sets.Add($"1x3 @ {RoundToNearestFive(oneRepMax * 0.75)}# \t(75%)"); //working
                    sets.Add($"1x3 @ {RoundToNearestFive(oneRepMax * 0.85)}# \t(85%)"); //working
                    sets.Add($"1xAMRAP @ {RoundToNearestFive(oneRepMax * 0.50)}#"); //empty the tank
                    break;
                case "Day 3": //5-3-1 75-85-95%, days 3,6,9
                case "Day 6":
                case "Day 9":
                    AddWarmupSets();
                    sets.Add($"1x5 @ {RoundToNearestFive(oneRepMax * 0.70)}# \t(70%)"); //working
                    sets.Add($"1x3 @ {RoundToNearestFive(oneRepMax * 0.80)}# \t(80%)"); //working
                    sets.Add($"1x1 @ {RoundToNearestFive(oneRepMax * 0.90)}# \t(90%)"); //working
                    sets.Add($"1xAMRAP @{RoundToNearestFive(oneRepMax * 0.50)}#"); //empty the tank
                    break;
                default:
                    sets.Add("No workout available for this day.");
                    break;
            }
            return sets;
        }
    }
}