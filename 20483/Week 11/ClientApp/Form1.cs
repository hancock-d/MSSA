using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClientApp
{

    public partial class Form1 : Form
    {
        HttpClient moviesClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) //void return type
        {
            moviesClient.BaseAddress = new Uri("http://localhost:5059/api/Movies");
            var movieresponse = await moviesClient.GetAsync(moviesClient.BaseAddress); //passing whatever was specific in the URI into here
            if (movieresponse.IsSuccessStatusCode)
            {
                var list = await movieresponse.Content.ReadFromJsonAsync<List<Movie>>();
                moviesGrid.DataSource = list;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e) //must be serialized, void return type
        {
            using StringContent jsonContent = new(JsonSerializer.Serialize(new Movie() { MovieId = 4, Title = "Test Movie", Rating = 8.9f, SuggestedAudience = "R" }), Encoding.UTF8, "application/json"); //forgot releaseyear
            using HttpResponseMessage response = await moviesClient.PostAsync("Movies", jsonContent);
            if (response.IsSuccessStatusCode) { MessageBox.Show("Movie added"); }

        }

        private async void btnGetweather_Click(object sender, EventArgs e)
        {
            var httpclient = new HttpClient();
            httpclient.BaseAddress = new Uri("https://api.tomorrow.io/v4/weather/realtime?location=98466%20US&apikey=Q1ZqaWakvuVkYEzgGJxotQ8363O2Ors5"); //%20 is a space--location=98466%20US
            var response = await httpclient.GetAsync(httpclient.BaseAddress);
            Root root = await response.Content.ReadFromJsonAsync<Root>(); //deserializing into a single object <Root> (unlike movies where we did a list line 24)
            MessageBox.Show($"Temp: {root.data.values.temperature}, Feels Like: {root.data.values.temperatureApparent}, UV: {root.data.values.uvIndex}");
        }
    }
    public class Movie
    {
        //Take class from the API
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; } //1980
        public float Rating { get; set; } // 8.9
        public string SuggestedAudience { get; set; } //audience rating--R, PG-13
    }
}
