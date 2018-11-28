using System;
using Tavisca.WeatherApp.Model.Interface;
using Tavisca.WeatherApp.Model.Model;
using Tavisca.WeatherApp.Plugins.Factory;

namespace Tavisca.WeatherApp.OpenWeatherAdapter
{
    public class WeatherReportDataProvider : IWeatherDataProvider
    {
        public WeatherReportResponseModel GetWeatherReport(WeatherReportRequestModel requestModel)
        {
            var adapterInstance
                =new WeatherAdapterFactory().GetInstance("OpenWeather");

            var response
                = adapterInstance.GetWeatherReport(requestModel);

            return response;
        }
    }
}
