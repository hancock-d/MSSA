using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mod9_WPF_Product_CRUD.Data;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Mod9_WPF_Product_CRUD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        // We configured our dependencies in the following code and registered them with services collection

        private ServiceProvider _serviceProvider;
        public App()
        {
            //Collection of services I need. Any other services required, add here by services.AddXXXX
            ServiceCollection services = new ServiceCollection(); //Services is just dependencies(?)
            services.AddDbContext<ProductContext>(option =>
            {
                option.UseSqlite("Data Source=Products.db"); //databse name (products.db), using SqlLite to create them
            }
            );
            services.AddSingleton<MainWindow>(); //**!!mainwindow is starting point--one instance of main window being created then services will be injected into main window
            _serviceProvider = services.BuildServiceProvider(); //use services collection to build all the services provided
        }

        private void OnStartUp(object sender, StartupEventArgs e) //writing an event handler on startup
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
//StartupUri in App.xaml change to Startup = "OnStartUp"