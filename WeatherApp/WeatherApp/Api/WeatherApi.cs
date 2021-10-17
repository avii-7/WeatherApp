using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Model;
using Newtonsoft.Json;


namespace WeatherApp.Api
{
    public class WeatherApi
    {
        public static async Task<WeatherModel> GetWeatherData(string city)
        {
            string BaseUrl = "http://api.weatherstack.com/";
            HttpClient httpClient = new HttpClient();
            Task<HttpResponseMessage> contentsTask = httpClient.GetAsync(BaseUrl + "current?access_key=6a0bc4ab6e5b8461e5c00c174ca94e35&query=" + city);
            string jsonResponse = await contentsTask.Result.Content.ReadAsStringAsync().ConfigureAwait(false);
            return !string.IsNullOrEmpty(jsonResponse) ? JsonConvert.DeserializeObject<WeatherModel>(jsonResponse) : null;
        }
    }
}
