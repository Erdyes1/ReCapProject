using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.UserFirstName).NotEmpty();
            RuleFor(p => p.UserFirstName).MinimumLength(2);
            RuleFor(p => p.UserLastName).NotEmpty();
            RuleFor(p => p.UserLastName).MinimumLength(2);
            RuleFor(p => p.UserEmail).NotEmpty();
            RuleFor(p => p.UserPassword).NotEmpty();

        }
    }
}
