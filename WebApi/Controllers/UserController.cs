using Application.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/User")]
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
