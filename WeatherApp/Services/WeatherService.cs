namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetWeatherAsync(string location)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://the-weather-api.p.rapidapi.com/api/weather/"+location),
                Headers =
                {
                    { "x-rapidapi-key", "e57e719db6msh9dc2b48024e3204p124d17jsn3c4a4ed54b0c" }, //RapidAPI'da The Weather API da bulunan key ile değişebilirsiniz kullanım limiti hatası verirse.
                    { "x-rapidapi-host", "the-weather-api.p.rapidapi.com" },
                },
            };

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }
    }
}
