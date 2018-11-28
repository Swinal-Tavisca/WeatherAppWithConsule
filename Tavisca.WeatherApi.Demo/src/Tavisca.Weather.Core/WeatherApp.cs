using Tavisca.WeatherApp.Model.Interface;
using Tavisca.WeatherApp.Model.Model;
using Tavisca.WeatherApp.OpenWeatherAdapter;

namespace Tavisca.WeatherApp.Core
{
    public class WeatherApp: IWeatherApp
    {
        private readonly IWeatherDataProvider _weatherDataProvider;
        public WeatherApp()
        {
            _weatherDataProvider = new WeatherReportDataProvider();
        }

        public WeatherReportResponseModel GetWeatherReport(WeatherReportRequestModel request)
        {
            return
                _weatherDataProvider.GetWeatherReport(request);
        }
       
    }
}
