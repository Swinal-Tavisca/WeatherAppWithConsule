using System;
using Tavisca.Platform.Common.Models;
using Tavisca.WeatherApp.Model.Interface;
using Tavisca.WeatherApp.Model.Model;
using Tavisca.WeatherApp.OpenWeatherAdapter.Model;
using Tavisca.WeatherApp.OpenWeatherAdapter.Translators;

namespace Tavisca.WeatherApp.OpenWeatherAdapter.Model
{
    public class OpenWeatherAdapter : WeatherReportBase, IWeatherAdapter
    {
        private readonly OpenWeatherAppSvcSettings _settings;

        public OpenWeatherAdapter(OpenWeatherAppSvcSettings settings)
        {
            _settings = settings;
        }

        public WeatherReportResponseModel GetWeatherReport(WeatherReportRequestModel requestModel)
        {
            if (_settings == null)
                throw new BaseApplicationException(ErrorMessages.MandatoryFieldMissing("OpenWeatherSvcSettings"), FaultCodes.MandatoryFieldMissing);

            var url = GenerateUrl(requestModel);

            var responseObj = Execute<OpenWeatherResponse>(url);

            return responseObj.ToModel();
        }

        private string GenerateUrl(WeatherReportRequestModel requestModel)
        {
            return $"{_settings.Url}?q={requestModel.CityName}&APPID={_settings.ApiKey}";
        }
    }
}
