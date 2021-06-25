using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class FuelTypeValidator : AbstractValidator<FuelType>
    {
        public FuelTypeValidator()
        {
            RuleFor(f => f.FuelTypeName).NotEmpty().MinimumLength(2);
        }
    }
}
