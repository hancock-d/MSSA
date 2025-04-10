namespace Phoneword
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //OnTranslate (Translate) button method -- TranslateButton button tap
        //If textbox is occupied, "call #"
        //Else, disable button
        string? translatedNumber;
        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);


            if (!string.IsNullOrEmpty(translatedNumber))
            {
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }
        }

        //CallButton (call) button method -- CallButton tap
        //Asynchronous operations
        //OnCall waits to verify user's choice

        async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                try
                {
                    if (PhoneDialer.Default.IsSupported && !string.IsNullOrWhiteSpace(translatedNumber))
                        PhoneDialer.Default.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Unable to dial", "Phone number was invalid.", "OK");
                }
                catch (Exception)
                {
                    //Other error has occurred.
                    await DisplayAlert("Unable to dial", "Phone dialing failed.", "OK");
                }
            }
        }

    }

}
