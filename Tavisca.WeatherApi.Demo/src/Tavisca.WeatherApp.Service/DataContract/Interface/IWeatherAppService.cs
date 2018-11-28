using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Model.Model;
using Tavisca.WeatherApp.Service.DataContract.Response;

namespace Tavisca.WeatherApp.Service.DataContract.Interface
{
    public interface IWeatherAppService
    {
        WeatherReportResponse GetReportByCityName(WeatherReportByCityNamerequest request);
        //WeatherReportResponse GetReportByCityId(WeatherReportByCityIdRequest request);
        //WeatherReportResponse GetReportByCityZip(WeatherReportByZipCodeRequest request);

    }
}
