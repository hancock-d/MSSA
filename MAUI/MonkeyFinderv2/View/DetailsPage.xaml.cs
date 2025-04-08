using MonkeyFinderv2.ViewModel;

namespace MonkeyFinderv2.View;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(MonkeyDetailsViewModel vm) //add this, inject it
    {
        InitializeComponent();
        BindingContext = vm; //add this
    }
}