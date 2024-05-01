using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(c => c.ReturnDate).NotEmpty();
            RuleFor(c => c.CarId).NotEmpty();
        }
    }
}
