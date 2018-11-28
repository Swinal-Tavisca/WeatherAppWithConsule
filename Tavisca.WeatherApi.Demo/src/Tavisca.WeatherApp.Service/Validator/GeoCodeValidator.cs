using System;
using FluentValidation;
using System.Collections.Generic;
using System.Text;

using Tavisca.Platform.Common.Models;
using Tavisca.WeatherApp.Service.DataContract;

namespace Tavisca.WeatherApp.Service.Validator
{
    public class GeoCodeValidator: AbstractValidator<GeoCode>
    {
        public GeoCodeValidator()
        {
            RuleFor(x=> x.latitude)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                 .WithErrorCode(FaultCodes.MandatoryFieldMissing)
                .WithMessage(ErrorMessages.MandatoryFieldMissing("Latitude"))
                .NotEmpty()
                .WithErrorCode(FaultCodes.InvalidValueForInputType)
                .WithMessage(ErrorMessages.InvalidValueForInputType("GeoCode", "latitude", "string"));

            RuleFor(x => x.longitude)
                 .Cascade(CascadeMode.StopOnFirstFailure)
                 .NotNull()
                 .WithErrorCode(FaultCodes.MandatoryFieldMissing)
                 .WithMessage(ErrorMessages.MandatoryFieldMissing("Longitude"))
                 .NotEmpty()
                 .WithErrorCode(FaultCodes.InvalidValueForInputType)
                 .WithMessage(ErrorMessages.InvalidValueForInputType("GeoCode", "longitude", "string"));
        }
    }
}
