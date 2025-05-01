using StrengthBuilder.View;

namespace StrengthBuilder
{
    //builds the app and starts it to the correct page
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        //Had to create a delay to let the shell fully load, otherwise loginpage was null
        //by creating a new instance of the shell
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var shell = new AppShell();

            Task.Run(async () =>
            {
                await Task.Delay(100); //wait for the shell to load
                await MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    await Shell.Current.GoToAsync(nameof(LoginPage));
                });
            });

            return new Window(shell);
            //return new Window(new AppShell());
        }
    }
}