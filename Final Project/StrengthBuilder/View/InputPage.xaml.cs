using StrengthBuilder.ViewModels;

namespace StrengthBuilder.View;

public partial class InputPage : ContentPage
{
    //private readonly InputViewModel _viewModel;
    public InputPage(InputViewModel viewModel)
    {
        InitializeComponent();
        //_viewModel = viewModel;
        BindingContext = viewModel; //set the binding context to the view model
    }
}