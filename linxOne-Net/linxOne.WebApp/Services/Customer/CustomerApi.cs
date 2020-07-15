using linxOne.ViewModel.Common;
using linxOne.ViewModels.Common;
using linxOne.ViewModels.Customer.DataTransferObject;
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

namespace linxOne.WebApp.Services.Customer
{

    public class CustomerApi : ICustomerApi
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CustomerApi(IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<int> Create(CustomerCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
           
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
           
           
            var json = JsonConvert.SerializeObject(request);
            var httpContext = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"/api/customer",httpContext);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<int>(result);
            }

           return  JsonConvert.DeserializeObject<int>(result);
        }

        public async Task<ApiResult<CustomerViewRequest>> GetById(int id)
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"api/customer/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<CustomerViewRequest>>(body);

            }
            return JsonConvert.DeserializeObject<ApiErrorResult<CustomerViewRequest>>(body);
        }

        public async Task<ApiResult<PageViewModel<CustomerViewRequest>>> GetCustomerPaging(GetCustomerPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", session);
            var response = await client.GetAsync($"/api/customer/paging?pageIndex=" +
                 $"{request.pageIndex}&pageSize={request.pageSize}&keyword={request.keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var cus = JsonConvert.DeserializeObject<ApiSuccessResult<PageViewModel<CustomerViewRequest>>>(body);

            return cus;
        }



    }
}
