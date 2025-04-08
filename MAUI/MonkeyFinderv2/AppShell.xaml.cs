using MonkeyFinderv2.View;

namespace MonkeyFinderv2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailsPage),typeof(DetailsPage)); // add this
        }
    }
}
