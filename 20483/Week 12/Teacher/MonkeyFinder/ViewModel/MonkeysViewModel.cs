//using AVFoundation;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Model;
using MonkeyFinder.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinder.ViewModel
{
    // Mainpage 
    public partial class MonkeysViewModel:BaseViewModel
    {
        MonkeyService monkeyService;
        IConnectivity connectivity;
        // to attach to front end
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public MonkeysViewModel(MonkeyService monkeyService,IConnectivity connectivity)
        {
            this.monkeyService = monkeyService;
            this.connectivity = connectivity; // object
            Title = "Monkey Finder App";
        }
        [RelayCommand]
        async Task GetMonkeysAsync()
        {
            if(IsBusy) return;
            try
            {
                if(connectivity.NetworkAccess!=NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("Internet issue!", "Check your internet connection", "Ok");
                    return;
                }
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();
                if (Monkeys.Count != 0)
                    Monkeys.Clear();
                foreach (var monkey in monkeys) { Monkeys.Add(monkey); }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);// debug doesn't execute in release
                await Shell.Current.DisplayAlert("Error", "Unable to get monkeys at this time", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
