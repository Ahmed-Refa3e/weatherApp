using Microsoft.AspNetCore.Mvc;
using weatherApp.Models;


namespace weatherApp.ViewComponents
{
    public class CityViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(CityWeather city)
        {
            ViewBag.CityCssClass = GetCssClassByFahrenheit(city.TemperatureFahrenheit);
            return View(city);
        }

        string GetCssClassByFahrenheit(int TemperatureFahrenheit)
        {
            return TemperatureFahrenheit switch
            {
                (< 44) => "blue-back",
                (>= 44) and (< 75) => "green-back",
                (>= 75) => "orange-back"
            };
        }
    }
}
