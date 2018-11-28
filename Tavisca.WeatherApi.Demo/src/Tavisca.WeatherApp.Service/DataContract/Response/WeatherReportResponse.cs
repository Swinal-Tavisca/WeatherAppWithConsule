﻿using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Service.DataContract.Model;

namespace Tavisca.WeatherApp.Service.DataContract.Response
{
    public class WeatherReportResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GeoLocation Coordinates { get; set; }
        public List<Weather> Weather { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public DateTime TimeSpan { get; set; }
        public AdditionalInfo AdditionalInfo { get; set; }
    }
}
