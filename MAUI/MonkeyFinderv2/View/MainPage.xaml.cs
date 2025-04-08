using MonkeyFinderv2.ViewModel;

namespace MonkeyFinderv2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MonkeysViewModel vm) //Add this line "inject MonkeysViewModel"
        {
            InitializeComponent();
            BindingContext = vm; //add this
        }
    }
}
