using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.DTOs.Authenticate;
using System.Net;
using System.Threading.Tasks;
using Application.Interfaces.Service;

namespace WebApi.Controllers
{
    [Route("api/authentcate")]
    [ApiController]
    public class AuthenticateController : BaseApiController
    {
        private readonly IAuthenticateService _iSender;
        public AuthenticateController(IAuthenticateService iSender)
        {
            _iSender = iSender;
        }

        [AllowAnonymous]
        [HttpPost, Route("signIn")]
        public async Task<IActionResult> SignIn(SignIn model)
        {
            var result = await _iSender.SignIn(model);
            return CustomResult(result, HttpStatusCode.OK);
        }
    }
}
