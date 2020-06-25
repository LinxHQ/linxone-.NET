using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using linxOne.Application.System.User;
using linxOne.ViewModels.System.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace linxOne.BackendApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
              
            }
            var data = await _userService.Authencate(request);
            if (string.IsNullOrEmpty(data.ResultObj))
            {
                return BadRequest(data);
            }
            return Ok(data);

        }
        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {

                var data = await _userService.Register(request);
                if (!data.IsSuccessed)
                {
                    return BadRequest(data);

                }
            }
            return Ok();

        }

        //http://localhost/api/user/paging?pageIndex=1&pageSize=10&Keyword=""
         [HttpGet("paging")]
        public async Task<IActionResult> GetUserPagingRquest([FromQuery]GetUserPagingRequest request)
        {
            var user = await _userService.GetUserPaging(request);
            return Ok(user);

        }
    }
}