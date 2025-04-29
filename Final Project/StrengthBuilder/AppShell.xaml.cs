using StrengthBuilder.Models;
using StrengthBuilder.View;
namespace StrengthBuilder
{
    //Registers pages and routes for navigation
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(InputPage), typeof(InputPage));
            Routing.RegisterRoute(nameof(WeekPage), typeof(WeekPage));
            Routing.RegisterRoute(nameof(WorkoutPage), typeof(WorkoutPage));
        }
    }
}
