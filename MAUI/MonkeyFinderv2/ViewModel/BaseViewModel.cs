using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinderv2.ViewModel
{
    public partial class BaseViewModel : ObservableObject //public partial
    {
        public BaseViewModel() 
        { 
        }

        // this will create a public property Title
        [ObservableProperty]
        string title; //title of page you want to change

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        public bool IsNotBusy => !IsBusy;

    }
}
