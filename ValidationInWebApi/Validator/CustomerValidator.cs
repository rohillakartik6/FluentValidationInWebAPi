using FluentValidation;
using ValidationInWebApi.Controllers;
using ValidationInWebApi.Models;

namespace ValidationInWebApi
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        private readonly ILogger<WeatherForecastController> _logger;
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName).NotNull().NotEmpty().WithMessage("First Name must not be empty");
            RuleFor(customer => customer.LastName).NotNull().NotEmpty().WithMessage("Last Name must not be empty");
            RuleFor(customer => customer.Email).EmailAddress().WithMessage("Please provide Valid Email Address");
            RuleFor(customer => customer.PhoneNumber).NotNull().Matches("[2-9]{1}[0-9]{9}").WithMessage("Please Provide Valid Phone Nummber").MinimumLength(10).MaximumLength(10);
            /*RuleFor(customer => customer.PhoneNumber).NotNull().Matches("^\\([1-9]{1}[0-9]{2}\\)[0-9]{3}-[0-9]{4}$").WithMessage("Please Provide Valid Phone Nummber");*/
        }
    }
}
