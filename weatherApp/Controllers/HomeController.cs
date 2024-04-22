using Microsoft.AspNetCore.Mvc;
using weatherApp.Models;

namespace weatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<CityWeather> cities = [
    new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2020-01-01 8:00"), TemperatureFahrenheit = 33 },

    new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-11 3:00"), TemperatureFahrenheit = 60 },

    new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"), TemperatureFahrenheit = 82 },

    new CityWeather() { CityUniqueCode = "car", CityName = "Cairo", DateAndTime = Convert.ToDateTime("2024-04-20 10:00"), TemperatureFahrenheit = 61 }
   ];
        [Route("/")]
        public IActionResult Index()
        {
            return View(cities);
        }

        [Route("weather/{cityCode?}")]
        public IActionResult City(string? cityCode)
        {
            CityWeather? city = cities.FirstOrDefault(temp => temp.CityUniqueCode == cityCode);
            return View(city);
        }

    }
}
