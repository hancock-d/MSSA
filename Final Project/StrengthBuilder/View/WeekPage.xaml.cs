using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WeekPage : ContentPage
{
    public WeekPage(WeekViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel; //set the binding context to the view model
    }
}