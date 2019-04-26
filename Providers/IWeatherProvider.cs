using System.Collections.Generic;
using moviejs.Models;

namespace moviejs.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
