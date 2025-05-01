using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class InputPage : ContentPage
{
    public InputPage(InputViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is InputViewModel viewModel)
        {
            viewModel.LoadCurrentSquatMax();
        }
    }
}