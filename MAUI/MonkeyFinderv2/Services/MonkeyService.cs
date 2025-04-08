using MonkeyFinderv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinderv2.Services
{
    /// <summary>
    /// /=====!!!!this is where your service connects to the database/server or API
    /// </summary>
    public class MonkeyService //make it public
    {
        HttpClient httpClient;
        public MonkeyService() //create constructor
        {
            httpClient = new HttpClient(); //create new instance
        }
        List<Monkey> monkeyList = new();
        public async Task<List<Monkey>> GetMonkeys() //List of Monkey type
        {
            if (monkeyList?.Count > 0) //if you already have monkeyList.  First time it will connect to API, second time it won't have to
            {
                return monkeyList;
            }
            var url = "https://montemagno.com/monkeys.json"; //expose API call(?)
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode) //if you get data
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }
            return monkeyList;
        }
    }
}
