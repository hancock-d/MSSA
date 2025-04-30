using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WeekPage : ContentPage
{
    public WeekPage(WeekViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel; //connect UI controls to the viewmodel
    }
}