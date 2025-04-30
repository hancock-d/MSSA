using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class WorkoutPage : ContentPage
{
    private readonly WorkoutViewModel _viewModel; //field to store the injected viewmodel
    public WorkoutPage(WorkoutViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = viewModel; //connect UI controls to the viewmodel
    }
    //Method to reload data reflecting selected day from viewmodel
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.LoadSquatSets();  //refresh sets for selected day and user session
    }
}