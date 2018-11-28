using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.WeatherApp.Model.Model;

namespace Tavisca.WeatherApp.OpenWeatherAdapter.Translators
{
    public static class WeatherReportResponseTranslator
    {
        public static WeatherReportResponseModel ToModel(this OpenWeatherResponse responseObj)
        {
            return new WeatherReportResponseModel
            {
                Id = responseObj.id,
                Name = responseObj.name,
                 Coordinates = new GeoCode()
                 {
                     Latitude = responseObj.coord.lat.ToString(),
                     Longitude = responseObj.coord.lon.ToString()
                 },
                Main = new WeatherApp.Model.Model.Main()
                {
                    Temp = responseObj.main.temp,
                    Pressure = responseObj.main.pressure,
                    Humidity = responseObj.main.humidity,
                    MinTemperature = responseObj.main.temp_min,
                    MaxTemperature = responseObj.main.temp_max
                },
                TimeSpan = new DateTime(responseObj.dt),
                Wind = new WeatherApp.Model.Model.Wind()
                {
                    Speed = responseObj.wind.speed,
                    Degree = responseObj.wind.deg
                },
                AdditionalInfo = new WeatherApp.Model.Model.AdditionalInfo()
                {
                    CountryCode = responseObj.cod.ToString(),
                    Cloudiness = responseObj.clouds.all,
                    Visibility = responseObj.visibility,
                    Sunrise = new DateTime(responseObj.sys.sunrise),
                    Sunset = new DateTime(responseObj.sys.sunset)

                },
                Weather = responseObj.weather.Select(x => new WeatherApp.Model.Model.Weather
                {
                    Type = x.main,
                    Description = x.description
                }).ToList()
            };
        }
    }
}
