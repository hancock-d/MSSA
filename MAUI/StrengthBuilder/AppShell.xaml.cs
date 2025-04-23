using StrengthBuilder.Models;
namespace StrengthBuilder
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Shell.Current.GoToAsync("//login"); //jump directly to login page --can't do this, tries to load the page before the shell is initialized

            //if (string.IsNullOrWhiteSpace(UserSession.Username))
            //    Shell.Current.GoToAsync("//login");
            //else
            //    Shell.Current.GoToAsync("//input");
        }
    }
}
