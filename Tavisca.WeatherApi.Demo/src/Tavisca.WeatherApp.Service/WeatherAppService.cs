using Tavisca.WeatherApp.Model;
using Tavisca.WeatherApp.Model.Interface;
using Tavisca.WeatherApp.Service.DataContract;
using Tavisca.WeatherApp.Service.DataContract.Interface;
using Tavisca.WeatherApp.Service.DataContract.Response;
using Tavisca.WeatherApp.Service.Translator;
using Tavisca.WeatherApp.Service.Validator;
using Core = Tavisca.WeatherApp.Core;

namespace Tavisca.WeatherApp.Service
{
    public class WeatherAppService : IWeatherAppService
    {
        private readonly IWeatherApp weatherApp;
        public WeatherAppService()
        {
            weatherApp = new Core.WeatherApp();
        }

        public WeatherReportResponse GetReportByCityName(WeatherReportByCityNamerequest request)
        {
            Validation.EnsureValid(request, new WeatherReportByCityNameRequestValidator());

            var requestModel = request.ToModel();

            //Here we will call the core service
            var responseModel = weatherApp.GetWeatherReport(requestModel);

            //Convert back the model to data contract

            return responseModel.ToDataContract();
        }
        //public WeatherReportResponse GetReportByCityId(WeatherReportByCityIdRequest request)
        //{
        //    Validation.EnsureValid(request, new WeatherReportByCityIdrequestValidator());
        //    var requestModel = request.ToModel();
        //    var responseModel = weatherApp.GetWeatherReport(requestModel);
        //    return null;
        //}
        //public WeatherReportResponse GetReportByCityZip(WeatherReportByZipCodeRequest request)
        //{
        //    Validation.EnsureValid(request, new WeatherReportByZipcodeRequestValidator());
        //    var requestModel = request.ToModel();
        //    var responseModel = weatherApp.GetWeatherReport(requestModel);
        //    return null;
        //}
    }
}
