using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using ValidationInWebApi.Models;
using ValidationInWebApi.Validator;

namespace ValidationInWebApi.Controllers
{
    [ApiController]
        [Route("[Controller]")]
    
    public class LoginController : Controller
    {
        [HttpPost(Name = "Login")]

        public IActionResult Login(LoginCredentials loginCredential) 
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult result= validator.Validate(loginCredential);
            if(result.IsValid)
            {
                return Ok("Login Succesfull");
            }
            else
            {
                return BadRequest("Username or password is incorrect");
            }
        }
    }
}
