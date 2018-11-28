using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tavisca.WeatherApp.Service.DataContract.Model;
using Tavisca.WeatherApp.Service.DataContract.Response;

namespace Tavisca.WeatherApp.Service.Translator
{
    public static class WeatherReportResponseTranslator
    {
        public static WeatherReportResponse ToDataContract(this Model.Model.WeatherReportResponseModel responseObj)
        {
            return new WeatherReportResponse
            {
                Id = responseObj.Id,
                Name= responseObj.Name,
                Coordinates = new GeoLocation
                {
                    Latitude = responseObj.Coordinates.Latitude,
                    Longitude = responseObj.Coordinates.Longitude
                },
                Main = new DataContract.Model.Main()
                {
                    Temp = responseObj.Main.Temp,
                    Pressure = responseObj.Main.Pressure,
                    Humidity = responseObj.Main.Humidity,
                    MinTemperature = responseObj.Main.MinTemperature,
                    MaxTemperature = responseObj.Main.MaxTemperature
                },
                Wind = new DataContract.Model.Wind()
                {
                    Speed = responseObj.Wind.Speed,
                    Degree = responseObj.Wind.Degree
                },
                AdditionalInfo = new DataContract.Model.AdditionalInfo()
                {
                    CountryCode = responseObj.AdditionalInfo.CountryCode,
                    Cloudiness = responseObj.AdditionalInfo.Cloudiness,
                    Visibility = responseObj.AdditionalInfo.Visibility,
                    Sunrise = responseObj.AdditionalInfo.Sunrise,
                    Sunset = responseObj.AdditionalInfo.Sunset

                },
                TimeSpan = responseObj.TimeSpan,
                Weather = responseObj.Weather.Select(x => new DataContract.Model.Weather()
                {
                    Type = x.Type,
                    Description = x.Description
                }).ToList()



            };
        }
    }
}
