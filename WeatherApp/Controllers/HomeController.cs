using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly WeatherService _weatherService;
        private readonly Dictionary<string, string> _weatherTranslations = new Dictionary<string, string>
    {
        { "Fair", "Açýk" },
        { "Clear", "Açýk" },
        { "Sunny", "Güneþli" },
        { "Cloudy", "Bulutlu" },
        { "Rain", "Yaðmurlu" },
        { "Snow", "Karlý" },
        { "Storm", "Fýrtýna" },
        { "Fog", "Sisli" },
        { "Partly Cloudy", "Parçalý Bulutlu" },
        { "Mostly Cloudy", "Çoðunlukla Bulutlu" },
        // Diðer terimler için de ekleyebilirsiniz
    };


        public HomeController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string location = "istanbul")
        {
            var weatherData = await _weatherService.GetWeatherAsync(location);
            var weatherJson = JObject.Parse(weatherData);

            var weatherDetails = weatherJson["data"];
            var weatherViewModel = new WeatherModel
            {
                City = weatherDetails["city"].ToString(),
                CurrentWeather = TranslateWeather(weatherDetails["current_weather"].ToString()),
                Temperature = weatherDetails["temp"].ToString(),
                Humidity = weatherDetails["humidity"].ToString(),
                Wind = weatherDetails["wind"].ToString(),
                BgImage = weatherDetails["bg_image"].ToString()
            };

            return View(weatherViewModel);
        }

        private string TranslateWeather(string englishWeather)
        {
            return _weatherTranslations.ContainsKey(englishWeather) ? _weatherTranslations[englishWeather] : englishWeather;
        }


    }
}
