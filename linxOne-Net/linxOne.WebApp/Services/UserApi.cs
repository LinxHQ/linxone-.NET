using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.System.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.WebApp.Services
{
    public class UserApi : IUserApi
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserApi(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();

            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/user/authenticate", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());

            }
            //var token = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<ApiResult<PageViewModel<UserViewRequest>>> GetUserPaging(GetUserPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);

            var response1 = await client.GetAsync($"/api/user/paging?pageIndex=" + $"{request.pageIndex}" +
                                                                $"&pageSize={request.pageSize}" +
                                                                $"&Keyword={request.Keyword}");

            var response = await client.GetAsync($"/api/user/paging?pageIndex=" +
                $"{request.pageIndex}&pageSize={request.pageSize}&Keyword={request.Keyword}");

            var body = await response.Content.ReadAsStringAsync();
           

            var users = JsonConvert.DeserializeObject<ApiSuccessResult<PageViewModel<UserViewRequest>>>(body);
              
            return  users;
        }
    }
}
