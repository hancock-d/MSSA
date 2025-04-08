using MonkeyFinder.Models;
using MonkeyFinder.PageModels;

namespace MonkeyFinder.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}