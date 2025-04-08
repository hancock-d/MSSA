using CommunityToolkit.Mvvm.Input;
using MonkeyFinderv2.Model;
using MonkeyFinderv2.Services;
using MonkeyFinderv2.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinderv2.ViewModel
{
    public partial class MonkeysViewModel : BaseViewModel //make public partial
    {
        MonkeyService monkeyService;
        IConnectivity connectivity;
        IGeolocation geolocation;
        public ObservableCollection<Monkey> Monkeys { get; } = new(); //read only
        public MonkeysViewModel(MonkeyService monkeySerice, IConnectivity connectivity, IGeolocation geolocation)
        {
            this.monkeyService = monkeySerice; //object creation is being done
            this.connectivity = connectivity;
            Title = "Monkey Finder App";
            this.geolocation = geolocation;
        }
        [RelayCommand]
        async Task GetMonkeysAsync()
        {
            if (IsBusy) return;
            try
            {
                if (connectivity.NetworkAccess != NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("Internet issue!", "Check your internet connection", "Ok");
                    return;
                }
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();
                if (Monkeys.Count != 0)
                    Monkeys.Clear();
                foreach (var monkey in monkeys)
                {
                    Monkeys.Add(monkey);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); //debug doesn't execute in release
                await Shell.Current.DisplayAlert("Error", "Unable to get monkeys at this time", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        [RelayCommand]
        async Task GetClosestMonkey()
        {
            if (IsBusy || Monkeys.Count == 0) //no closest monkey or is busy, nothing to return
                return;
            try
            {
                var location = await geolocation.GetLastKnownLocationAsync();
                if (location == null) //if last know location == null or is unknown, get current location
                {
                    location = await geolocation.GetLocationAsync(
                        new GeolocationRequest
                        {
                            DesiredAccuracy = GeolocationAccuracy.Medium,
                            Timeout = TimeSpan.FromSeconds(30) //wait for this time in seconds
                        });
                }
                if (location == null)
                {
                    //await Shell.Current.DisplayAlert("No Location", "Can't find your current location!", "Ok");
                    return; //can also display an alert message if you cannot find location
                }
                var first = Monkeys.OrderBy(x =>
                location.CalculateDistance(x.Latitude, x.Longitude, DistanceUnits.Miles)).FirstOrDefault();
                if (first == null) return;
                await Shell.Current.DisplayAlert("Closest Monkey", $"{first.Name} at {first.Location}", "Ok");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error", "Unable to get closest monkey!", "Ok");
            }
        }
        [RelayCommand]
        async Task GoToDetailsAsync(Monkey monkey)
        {
            if (monkey == null) return; //don't want to send a blank monkey to the page

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<string, object> //Takes object of monkey from one page to another
                {
                    {"Monkey", monkey}

                }



                );
        }
    }
}

