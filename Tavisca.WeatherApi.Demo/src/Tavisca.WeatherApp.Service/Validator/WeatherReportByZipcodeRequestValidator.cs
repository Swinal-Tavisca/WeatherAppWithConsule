using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Tavisca.Platform.Common.Models;
using Tavisca.WeatherApp.Service.DataContract;

namespace Tavisca.WeatherApp.Service.Validator
{
    public class WeatherReportByZipcodeRequestValidator : AbstractValidator<WeatherReportByZipCodeRequest>
    {
        public WeatherReportByZipcodeRequestValidator()
        {
            RuleFor(x => x.Zip)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithErrorCode(FaultCodes.MandatoryFieldMissing)
                .WithMessage(ErrorMessages.MandatoryFieldMissing("Zip"))
                .NotEmpty()
                .WithErrorCode(FaultCodes.InvalidValueForInputType)
                .WithMessage(ErrorMessages.InvalidValueForInputType("Zip", "zip", "string"));
        }
    }
}
