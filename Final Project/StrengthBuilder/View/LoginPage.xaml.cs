using StrengthBuilder.Helpers;
using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class LoginPage : ContentPage
{

    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is LoginViewModel viewModel)
        {
            var currentUser = UserSession.CurrentUser;

            if (UserSession.CurrentUser != null)
            {
                viewModel.Username = UserSession.CurrentUser.Username;
            }
            else
            {
                viewModel.Username = string.Empty;
            }
            viewModel.CanDeleteUser = currentUser != null;
        }
    }
}