using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using linxOne.Application.Customer;
using linxOne.ViewModels.Customer.DataTransferObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace linxOne.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {

            var cus = await _customerService.GetAll();
            return Ok(cus);

        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetCustomerPagingRequest request)
        {

            var cus = await _customerService.GetAllPaging(request);
            if (cus == null)
            {
                return BadRequest();
            }
            return Ok(cus);

        }

        [HttpGet("address")]
        public async Task<IActionResult> GetCustomerAddressByCustomerId(int id)
        {
            var data = await _customerService.GetCustomerAddressByCustomerId(id);


            return Ok(data);
        }

        [HttpGet("contact")]
        [Authorize]
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

        [HttpGet("invoice")]
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var cus = await _customerService.GetCustomerById(id);
            if (cus == null)
            {
                return BadRequest($"Cannot find Customer with id :{id}");
            }
            return Ok(cus);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromForm]CustomerCreateRequest request)
        {
            var CusId = await _customerService.Create(request);
            if (CusId == 0)
            {
                return BadRequest();

            }

            var cus = await _customerService.GetCustomerById(CusId);
            return CreatedAtAction(nameof(GetCustomerById), new { CusId }, cus);
        }
        [HttpPost("create/test")]
        public async Task<IActionResult> CreateCustomer1([FromForm]CustomerCreateRequest request)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var cus = await _customerService.Create1(request);
            if (!cus.IsSuccessed)
            {
                return BadRequest(cus);

            }
            return Ok(cus);

            //var result = await _customerService.GetCustomerById(CusId);
            //return CreatedAtAction(nameof(GetCustomerById), new { CusId }, cus);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] CustomerUpdateRequest request)
        {
            var result = await _customerService.Update(request);
            if (result == 0)
            {
                return BadRequest();

            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {

            var result = await _customerService.Delete(id);
            if (result == 0)
            {
                return BadRequest();

            }
            return Ok();
        }
    }
}