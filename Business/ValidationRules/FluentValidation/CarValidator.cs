using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.DailyPrice).GreaterThan(0);
        }
    }
}
