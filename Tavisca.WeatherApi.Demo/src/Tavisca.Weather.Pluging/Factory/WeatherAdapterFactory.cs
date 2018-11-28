using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.Common.Plugins.Configuration;
using Tavisca.Platform.Common.Configurations;
using Tavisca.WeatherApp.Model.Interface;
using Tavisca.WeatherApp.Service.DataContract.Model;
using Adapter = Tavisca.WeatherApp.OpenWeatherAdapter.Model;

namespace Tavisca.WeatherApp.Plugins.Factory
{
    public class WeatherAdapterFactory
    {
        private readonly IConfigurationProvider _configurationProvider;

        public WeatherAdapterFactory()
        {
            _configurationProvider = new ConfigurationProvider(KeyStore.ApplicationName);
        }

        public Adapter.OpenWeatherAppSvcSettings AppSettings
        {
            get
            {
                return _configurationProvider.GetGlobalConfiguration<Adapter.OpenWeatherAppSvcSettings>(KeyStore.SectionNames.AppSettings,KeyStore.AppSettingsKeys.OpenWeatherAppSettings);
            }
        } 

        public IWeatherAdapter GetInstance(string stratergy)
        {
            switch (stratergy.ToLower().Trim())
            {
                case "openweather":
                    {
                        var appSettings = AppSettings;

                        return new Adapter.OpenWeatherAdapter(appSettings);
                    }
                case "mock":
                default:
                    throw new NotImplementedException("Adapter for this instance is not implemented");
            }
        }
    }
}