using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Model.Model;

namespace Tavisca.WeatherApp.Model.Interface
{
    public interface IWeatherAdapter
    {
        WeatherReportResponseModel GetWeatherReport(WeatherReportRequestModel requestModel);
    }
}
