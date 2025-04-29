using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel viewModel) //inject the view model
    {
        InitializeComponent();
        BindingContext = viewModel; //set the binding context to the view model
    }
}