using System;
using FluentValidation;
using System.Collections.Generic;
using System.Text;
using Tavisca.WeatherApp.Service.DataContract;
using Tavisca.Platform.Common.Models;

namespace Tavisca.WeatherApp.Service.Validator
{
    public class WeatherReportByCityIdrequestValidator:AbstractValidator<WeatherReportByCityIdRequest>
    {
        public WeatherReportByCityIdrequestValidator()
        {
            RuleFor(x => x.CityId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode(FaultCodes.MandatoryFieldMissing)
                .WithMessage(ErrorMessages.MandatoryFieldMissing("CityId"))
                .NotEmpty()
                .WithErrorCode(FaultCodes.InvalidValueForInputType)
                .WithMessage(ErrorMessages.InvalidValueForInputType("CityId", "cityId", "string"));
        }


    }
}
