using _11._1WPFBookInventory.Data;
using System.Net;
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

namespace _11._1WPFBookInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookContext dbContext; //variable to inject service in the mainwindow
        Book newBook = new Book();
        Book selectedBook = new Book();
        public MainWindow(BookContext _dbcontext) //what we're injecting
        {
            this.dbContext = _dbcontext; //attach the dbContext
            InitializeComponent();
            GetBooks();
            AddBookGrid.DataContext = newBook; //attach newBook to grid
        }
        private void GetBooks() //"Refresh"
        {
            BookDG.ItemsSource = this.dbContext.Books.ToList();
        }
        private void AddBook(object sender, RoutedEventArgs e) //panel button
        {
            this.dbContext.Books.Add(newBook);
            this.dbContext.SaveChanges();
            GetBooks();
            newBook = new Book();
            AddBookGrid.DataContext = newBook;
        }

        private void UpdateBook(object sender, RoutedEventArgs e) //panel Button
        {
            this.dbContext.Update(selectedBook);
            this.dbContext.SaveChanges();
            GetBooks();
            selectedBook = new Book(); //create blank book/clear update form
            UpdateBookGrid.DataContext = selectedBook; //re-bind UI to blank book
        }

        private void UpdateBookForEdit(object sender, RoutedEventArgs e) //grid button, fetches the book frm the grid
        {
            selectedBook = (sender as FrameworkElement).DataContext as Book;
            UpdateBookGrid.DataContext = selectedBook;
        }
        private void DeleteBook(Object sender, RoutedEventArgs e) //grid button
        {
            var book = (sender as FrameworkElement).DataContext as Book;
            this.dbContext.Books.Remove(book);
            this.dbContext.SaveChanges();
            GetBooks();
        }
    }
}