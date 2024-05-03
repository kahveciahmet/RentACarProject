using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
        }
    }
}
