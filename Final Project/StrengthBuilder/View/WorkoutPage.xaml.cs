using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WorkoutPage : ContentPage
{
    private readonly WorkoutViewModel _viewModel; //why am I doing this again?
    public WorkoutPage(WorkoutViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel; //set the binding context to the view model
    }
    //Method to reload with data reflecting selected day
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.LoadSquatSets();

    }
}