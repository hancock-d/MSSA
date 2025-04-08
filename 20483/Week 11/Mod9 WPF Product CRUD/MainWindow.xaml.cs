using Mod9_WPF_Product_CRUD.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod9_WPF_Product_CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductContext dbContext; //just creating a variable of it so you can inject the service in the main window
        Product newProduct = new Product(); //will be associated with new grid we have in main window constructor
        public MainWindow(ProductContext _dbcontext) //_dbcontext can be any name, but that's what we're injecting(?) //Depdendecy injection in constructor
        {
            this.dbContext = _dbcontext; //whenever main window gets its instance created in App.xaml.cs; dbContext getting attached
            InitializeComponent();
            GetProducts();
            AddProductGrid.DataContext = newProduct; //attach newPRoduct to AddProductGrid
        }
        private void GetProducts()
        {
            ProductDG.ItemsSource = this.dbContext.Products.ToList(); //Bind the products coming from dbContext
        }

        private void UpdateProduct(object sender, RoutedEventArgs e)
        {
            this.dbContext.Update(selectedProduct);
            this.dbContext.SaveChanges();
            GetProducts();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            this.dbContext.Products.Add(newProduct);
            this.dbContext.SaveChanges();
            GetProducts();
            newProduct = new Product(); //refreshing add grid
            AddProductGrid.DataContext = newProduct; //refreshing add grid, associating it with a new (blank) product
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        Product selectedProduct = new Product(); //can create anywhere, will be used in event handlers

        private void UpdateProductForEdit(object sender, RoutedEventArgs e)
        {
            selectedProduct = (sender as FrameworkElement).DataContext as Product;
            UpdateProductGrid.DataContext = selectedProduct;
        }

        private void DeleteProduct(object sender, RoutedEventArgs e)
        {
            var product = (sender as FrameworkElement).DataContext as Product;
            this.dbContext.Products.Remove(product);
            this.dbContext.SaveChanges();
            GetProducts();
        }
    }
}