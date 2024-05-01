using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.UserId).NotEmpty();
        }
    }
}
