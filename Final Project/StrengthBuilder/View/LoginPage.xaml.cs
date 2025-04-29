using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;
    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel; //set the binding context to the view model
    }
}