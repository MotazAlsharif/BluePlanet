using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePlanet2.Services
{
    interface IWeatherService
    {
        Task<IEnumerable<Location>> GetLocations(string query);
        Task<WeatherResponse> GetWeather(Coordinate location);
    }
}
