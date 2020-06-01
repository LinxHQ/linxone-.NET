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
        [HttpGet("cus/address")]
        public async Task<IActionResult> GetCustomerAddressByCustomerId(int id)
        {
            var data = await _customerService.GetCustomerAddressByCustomerId(id);


            return Ok(data);
        }

        [HttpGet("cus/contact")]
        public async Task<IActionResult> GetCustomerContactByCustomerId(int id)
        {
            var data = await _customerService.GetCustomerContactByCustomerId(id);
            if (data == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(data);

            }

        }
        [HttpGet("cus/invoice")]
        public async Task<IActionResult> GetCustomerInvoiceByCustomerId(int id)
        {
            var data = await _customerService.GetCustomerInvoiceCustomerId(id);
            if (data == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(data);

            }

        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer()
        {

            return null;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer()
        {

            return null;
        }
    }
}