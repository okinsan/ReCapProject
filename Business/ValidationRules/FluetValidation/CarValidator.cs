using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluetValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage(Messages.CarNameInvalid);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100);
        }
    }
}
