using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelName).NotEmpty();
            RuleFor(c => c.ModelName).MinimumLength(2);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(1000);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10000).When(c => c.BrandId == 1);
        }

    }
}
