using weatherApp.Models;


namespace ServiceContracts
{
    public interface IWeatherService
    {
        List<CityWeather> GetWeatherDetails();
        //- Returns a list of CityWeather objects that contains weather details of cities
        CityWeather? GetWeatherByCityCode(string CityCode);
        //- Returns an object of CityWeather based on the given city code
    }
}
