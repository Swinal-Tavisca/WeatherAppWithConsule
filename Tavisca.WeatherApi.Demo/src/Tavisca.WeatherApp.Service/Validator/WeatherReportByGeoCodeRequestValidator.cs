using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Tavisca.Platform.Common.Models;
using Tavisca.WeatherApp.Service.DataContract;

namespace Tavisca.WeatherApp.Service.Validator
{
    public class WeatherReportByGeoCodeRequestValidator : AbstractValidator<WeatherReportByGeoCodeRequest>
    {
        public WeatherReportByGeoCodeRequestValidator()
        {
            RuleFor(x => x.GeoCode)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode(FaultCodes.MandatoryFieldMissing)
                .WithMessage(ErrorMessages.MandatoryFieldMissing("GeoCode"))
                .SetValidator(new GeoCodeValidator());
        }
    }
}
