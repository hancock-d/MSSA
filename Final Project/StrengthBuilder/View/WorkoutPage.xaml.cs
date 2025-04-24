using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage()
    {
        InitializeComponent();
    }
    //Method to reload with data reflecting selected day
    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is WorkoutViewModel viewModel)
        {
            viewModel.LoadSquatSets();
        }
    }
}