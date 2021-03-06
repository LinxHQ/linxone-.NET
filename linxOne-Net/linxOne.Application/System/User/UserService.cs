﻿using linxOne.Data.Entities;
using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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

        public async Task<ApiResult<PageViewModel<UserViewRequest>>> GetUserPaging(GetUserPagingRequest request)
        {
            var q = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                q = q.Where(x => x.UserName.ToLower().Contains(request.Keyword.ToLower())
                || x.PhoneNumber.ToLower().Contains(request.Keyword.ToLower())
                || x.Email.ToLower().Contains(request.Keyword.ToLower())
                );
            }
            int totalRow = await q.CountAsync();
            var data = await q.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize).Select(c => new UserViewRequest()
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Username = c.UserName,
                    Birth = c.Birth,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber
                }).ToListAsync();

            var pageViewModel = new PageViewModel<UserViewRequest>()
            {
                TotalRecords = totalRow,
                PageIndex=request.pageIndex,
                PageSize=request.pageSize,
                Items = data

            };
            return new ApiSuccessResult<PageViewModel<UserViewRequest>>(pageViewModel);
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
