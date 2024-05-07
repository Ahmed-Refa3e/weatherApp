using ServiceContracts;
using weatherApp.Models;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private readonly List<CityWeather> _cities;

        public WeatherService()
        {
            _cities =
                [
                    new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2020-01-01 8:00"), TemperatureFahrenheit = 33 },
                    new CityWeather() { CityUniqueCode = "NYC", CityName = "New York", DateAndTime = Convert.ToDateTime("2030-01-11 3:00"), TemperatureFahrenheit = 60 },
                    new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"), TemperatureFahrenheit = 82 },
                    new CityWeather() { CityUniqueCode = "car", CityName = "Cairo", DateAndTime = Convert.ToDateTime("2024-04-20 10:00"), TemperatureFahrenheit = 61 }
                ];
        }

        public CityWeather? GetWeatherByCityCode(string CityCode)
        {
            CityWeather? city = _cities.FirstOrDefault(c => c.CityUniqueCode == CityCode);
            return city;
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return _cities;
        }
    }
}
