using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.WeatherApp.Model.Model
{
    public class WeatherReportRequestModel
    {
        public string CityName { get; set; }
        public string CityId { get; set; }
        public string ZipCode { get; set; }
        public GeoCode GeoCode { get; set; }
    }
}
