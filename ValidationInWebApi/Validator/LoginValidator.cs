using FluentValidation;
using ValidationInWebApi.Controllers;
using ValidationInWebApi.Models;

namespace ValidationInWebApi.Validator
{
    public class LoginValidator : AbstractValidator<LoginCredentials>
    {
        public LoginValidator() {

            RuleFor(customer => customer.username).NotNull().NotEmpty().WithMessage("First Name must not be empty");
            RuleFor(customer => customer.password).NotNull().NotEmpty().WithMessage("Last Name must not be empty");
        }
    }
}
