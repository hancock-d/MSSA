namespace StrengthBuilder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new StrengthBuilder.View.InputPage());
            //return new Window(new StrengthBuilder.View.LoginPage());
            return new Window(new AppShell());
        }
    }
}