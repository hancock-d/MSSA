using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WorkoutPage : ContentPage
{
    private readonly WorkoutViewModel _viewModel; //declare a field to store the view model
    public WorkoutPage(WorkoutViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = viewModel; //set the binding context to the view model
    }
    //Method to reload with data reflecting selected day
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.LoadSquatSets();  //use stored field

    }
}