using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using MonkeyFinderv2.Model;

namespace MonkeyFinderv2.ViewModel
{
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeyDetailsViewModel : BaseViewModel //public partial, inherit
    {
        IMap map;
        public MonkeyDetailsViewModel(IMap map)
        {
            this.map = map;
        }

        [ObservableProperty]
        Monkey monkey;

        [RelayCommand]
        async Task OpenMapAsync()
        {
            try
            {
                await map.TryOpenAsync(Monkey.Latitude, Monkey.Longitude, //traveling to monkeys lat/long, open maps

                    new MapLaunchOptions { Name = Monkey.Name, NavigationMode = NavigationMode.Driving }

                    );
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                await Shell.Current.DisplayAlert("Error", "Unable to open map", "Ok");
            }
        }
    }
}
