using _11._1WPFBookInventory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace _11._1WPFBookInventory
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<BookContext>(option =>
            {
                option.UseSqlite("Data Source = Books.db"); //db name Books, using sqlite to create it
            }
            );
            services.AddSingleton<MainWindow>(); //one instance of mainwindow only
            _serviceProvider = services.BuildServiceProvider();
        }
        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
//Edit startup in app.xaml