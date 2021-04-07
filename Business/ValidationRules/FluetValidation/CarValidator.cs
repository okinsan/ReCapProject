using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluetValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage(Messages.CarNameInvalid);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100);
        }
    }
}
