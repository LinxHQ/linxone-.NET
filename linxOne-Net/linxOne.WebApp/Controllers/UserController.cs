﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using linxOne.ViewModels.System.User;
using linxOne.ViewModels.Common;
using linxOne.WebApp.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Http;
using linxOne.Utility.Constants;

namespace linxOne.WebApp.Controllers
{
    public class UserController : BaseController
    {
        public readonly IUserApi _userApi;
        public readonly IConfiguration _configuration;

        public UserController(IUserApi userApi,IConfiguration configuration)
        {
            _userApi = userApi;
            _configuration = configuration;
        }
        public async Task<IActionResult>Index(string keyword, int pageIndex = 1,int pageSize = 10)
        {
           
            var request = new GetUserPagingRequest()
            { 
                Keyword = keyword,
                pageIndex = pageIndex,
                pageSize = pageSize
            };
            var data = await _userApi.GetUserPaging(request);
            ViewBag.keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View(data.ResultObj);
        }
       
        

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }
    }
}