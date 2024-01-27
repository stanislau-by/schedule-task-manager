using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        public Task<string> Authorization()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task Registration()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task ResetPassword()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task RestorePassword()
        {
            throw new NotImplementedException();
        }
    }
}
