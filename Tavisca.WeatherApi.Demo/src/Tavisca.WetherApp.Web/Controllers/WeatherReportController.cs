using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tavisca.WeatherApp.Service;
using Tavisca.WeatherApp.Service.DataContract;
using Tavisca.WeatherApp.Service.DataContract.Interface;

namespace Tavisca.WetherApp.Web.Controllers
{
    [Route("api/weatherReport")]
    [ApiController]
    public class WeatherReportController : ControllerBase
    {

        private readonly IWeatherAppService WeatherAppService;

        public WeatherReportController()
        {
            WeatherAppService = new WeatherAppService();
        }

        [HttpPost]
        [Route("get_by_city_name")]
        public IActionResult GetReportByCityName([FromBody] WeatherReportByCityNamerequest request)
        {
            var response = WeatherAppService.GetReportByCityName(request);
            return Ok(response);
        }

        //[HttpPost]
        //[Route("get_by_city_id")]
        //public IActionResult GetReportByCityId([FromBody] WeatherReportByCityIdRequest request)
        //{
        //    WeatherAppService.GetReportByCityId(request);

        //    return Ok();
        //}

        //[HttpPost]
        //[Route("get_by_zip_code")]
        //public IActionResult GetReportByCityZip([FromBody] WeatherReportByZipCodeRequest request)
        //{
        //    WeatherAppService.GetReportByCityZip(request);
        //    return Ok();
        //}



    }
}
