using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Account;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("login")]
        public IActionResult Login(LoginModel model)
        {
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        [HttpPost("registration")]
        public IActionResult Registration(RegistrationModel model)
        {
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        [HttpPost("restore-password")]
        public IActionResult RestorePassword(RestorePasswordModel mode)
        {
            throw new NotImplementedException();
        }

        [AllowAnonymous]
        [HttpPut("reset-password/{token}")]
        public IActionResult ResetPassword(string token, [FromBody] ResetPasswordModel model)
        {
            throw new NotImplementedException();
        }
    }
}
