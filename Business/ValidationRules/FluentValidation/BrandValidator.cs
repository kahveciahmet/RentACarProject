using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
        }
    }
}
