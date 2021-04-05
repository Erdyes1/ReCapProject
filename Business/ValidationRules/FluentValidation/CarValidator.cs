using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarModel).NotEmpty();
            RuleFor(p => p.CarModel).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            // RuleFor(p => p.).GreaterThanOrEqualTo(10).When(p => p.CategoryID == 1);
            // Kendi ´girdigimiz kural
            RuleFor(p => p.CarModel).Must(StartWithA).WithMessage("Model A harfi ile baslamali");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
