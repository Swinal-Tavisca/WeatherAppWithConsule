using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Model.Model;
using Tavisca.WeatherApp.Service.DataContract;

namespace Tavisca.WeatherApp.Service.Translator
{
    public static  class WeatherAppRequestTranslator
    {
        public static WeatherReportRequestModel ToModel(this WeatherReportByCityNamerequest request)
        {
            return new WeatherReportRequestModel
            {
                CityName = request.CityName
            };
        }

        public static WeatherReportRequestModel ToModel(this WeatherReportByCityIdRequest request)
        {
            return new WeatherReportRequestModel
            {
                CityId = request.CityId
            };
        }
        public static WeatherReportRequestModel ToModel(this WeatherReportByGeoCodeRequest request)
        {
            return new WeatherReportRequestModel
            {
                GeoCode = new Model.Model.GeoCode
                {
                    Latitude=request.GeoCode?.latitude,
                    Longitude=request.GeoCode?.longitude
                }

                
            };
        }
        public static WeatherReportRequestModel ToModel(this WeatherReportByZipCodeRequest request)
        {
            return new WeatherReportRequestModel
            {
                ZipCode = request.Zip
            };
        }
    }
}
