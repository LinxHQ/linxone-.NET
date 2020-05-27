using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linxOne.Application.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace linxOne.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var cus = await _customerService.GetAll();
            return Ok(cus);

        }
    }
}