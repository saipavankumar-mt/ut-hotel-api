using Contracts.Interface;
using Contracts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ut_host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthController : BaseAPIController
    {
        private IUserAuthService _userAuthService;
        public UserAuthController(IUserAuthService userAuthService)
        {
            _userAuthService = userAuthService;
        }

        [HttpPost("signin")]
        public async Task<IActionResult> UserSignIn([FromBody] SignInRequest request)
        {
            return Ok(await _userAuthService.UserSignInAsync(request));
        }
    }
}
