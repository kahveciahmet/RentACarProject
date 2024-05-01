using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

        }
    }
}
