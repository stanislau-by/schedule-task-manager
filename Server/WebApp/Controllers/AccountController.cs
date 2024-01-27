using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Account;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationModel model)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult RestorePassword(RestorePasswordModel mode)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{token}")]
        public IActionResult ResetPassword(string token, [FromBody] ResetPasswordModel model)
        {
            throw new NotImplementedException();
        }
    }
}
