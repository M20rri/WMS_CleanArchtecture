using Application.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Controllers.v1
{
    [Authorize]
    [Route("api/User")]
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        private readonly IUserService _iSender;
        public UserController(IUserService iSender) => _iSender = iSender;

        [HttpGet, Route("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _iSender.GetAll();
            return CustomResult(response, HttpStatusCode.OK);
        }
    }
}
