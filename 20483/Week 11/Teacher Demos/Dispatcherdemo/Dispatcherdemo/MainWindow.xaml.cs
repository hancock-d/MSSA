using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dispatcherdemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                  string currentTime = DateTime.Now.ToLongTimeString();
                lblTime.Dispatcher.BeginInvoke(new Action(() => SetTime(currentTime)));

               // string currentTime = DateTime.Now.ToString();
               //SetTime(currentTime);
            });
        }
        private void SetTime(string time)
        {
            lblTime.Content = time;
        }

        private async void btnGetCoffees_Click(object sender, RoutedEventArgs e)
        {
            //synchronous 
            // asynchronous 
             await GetCoffees(RemoveDuplicates);
            //Getc();
        }
        public void Getc()
        {
            var coffeeList = new List<string>();
            coffeeList.Add("Caffe Americano");
            coffeeList.Add("Café au Lait");
            coffeeList.Add("Café au Lait");
            coffeeList.Add("Espresso Romano");
            coffeeList.Add("Latte");
            coffeeList.Add("Macchiato");
            Thread.Sleep(10000);
            lstCoffees.ItemsSource = coffeeList;


        }


        public async Task GetCoffees(Action<IEnumerable<string>> callback)
        {   
            // Simulate a call to a database or a web service.  
            var coffees = await Task.Run(() =>
            {

                var coffeeList = new List<string>();
                coffeeList.Add("Caffe Americano");
                coffeeList.Add("Café au Lait");
                coffeeList.Add("Café au Lait");
                coffeeList.Add("Espresso Romano");
                coffeeList.Add("Latte");
                coffeeList.Add("Macchiato");
                Thread.Sleep(6000);
                return coffeeList;
            }); 
             // Invoke the callback method asynchronously.   
             await Task.Run(() => callback(coffees));
        }
        private void RemoveDuplicates(IEnumerable<string> coffees)
        {
            IEnumerable<string> uniqueCoffees = coffees.Distinct();
            Dispatcher.BeginInvoke(new Action(() => {
                lstCoffees.ItemsSource = uniqueCoffees;
            }));
          }

    }
    }
