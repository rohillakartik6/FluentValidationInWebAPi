using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationInWebApi.Models;
using FluentValidation;
using FluentValidation.Results;



namespace ValidationInWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }
        [HttpPost(Name = "post")]
        public IActionResult Index(Customer customer)
        {
            CustomerValidator validator = new CustomerValidator();
            ValidationResult result = validator.Validate(customer);
            if (result.IsValid)
            {
                return Ok("Success");
            }
            else
            {
                return BadRequest(string.Join(", ", result.Errors));
            }
        }
    }
}