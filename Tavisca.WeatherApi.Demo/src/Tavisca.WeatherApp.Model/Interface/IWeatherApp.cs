using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Model.Model;

namespace Tavisca.WeatherApp.Model.Interface
{
    public interface IWeatherApp
    {
        WeatherReportResponseModel GetWeatherReport(WeatherReportRequestModel request);
    }
}
