using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linxOne.ViewModels.Customer.DataTransferObject;
using linxOne.WebApp.Services.Customer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace linxOne.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerApi _customerApi;
        private readonly IConfiguration _configuration;
        public CustomerController(ICustomerApi customerApi, IConfiguration configuration)
        {
            _customerApi = customerApi;

            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetCustomerPagingRequest()
            {
                keyword = keyword,
                pageIndex = pageIndex,
                pageSize = pageSize
            };
            var data = await _customerApi.GetCustomerPaging(request);
            ViewBag.keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }


            return View(data.ResultObj);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                //var data = await _customerApi
            }
            return View();
        }


    }
}