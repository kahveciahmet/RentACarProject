using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.BrandId).NotEmpty().GreaterThan(0);
            RuleFor(c=>c.ColorId).NotEmpty().GreaterThan(0);
        }
    }
}
