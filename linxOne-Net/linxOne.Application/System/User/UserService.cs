using linxOne.Data.Entities;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.System.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<AUser> _userManager;
        private readonly SignInManager<AUser> _signInManager;
        private readonly RoleManager<ARoles> _roleManager;
        private readonly IConfiguration _config;

        public UserService(UserManager<AUser> userManager,
            SignInManager<AUser> signInManager,
            RoleManager<ARoles> roleManager,
            IConfiguration config
            )

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            var userName = await _userManager.FindByNameAsync(request.UserName);
            if (userName == null) return new ApiErrorResult<string>("userName not exist!");

            var data = await _signInManager.PasswordSignInAsync(userName, request.Password, request.RememberMe, true);
            if (!data.Succeeded)
            {

                return new ApiErrorResult<string>("Login Fails");
            }
            var role = _userManager.GetRolesAsync(userName);
            var claims = new[]
{
                    new Claim(ClaimTypes.Email,userName.Email),
                    new Claim(ClaimTypes.GivenName,userName.FirstName),
                    new Claim(ClaimTypes.Role, string.Join(";",role)),
                    new Claim(ClaimTypes.Name,request.UserName)
             };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _config["Tokens:Issuer"], _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3), signingCredentials: creds);
           // var tk = new JwtSecurityTokenHandler().WriteToken(token);
            //var result = new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));

        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = new AUser()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Birth = request.Birth,
                UserName = request.Username,
                PasswordHash = request.Password,
                PhoneNumber = request.PhoneNumber,
            };
            var data = await _userManager.CreateAsync(user, request.Password);
            if (data.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Register fail!");
        }
    }
}
