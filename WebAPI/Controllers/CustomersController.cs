using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerServie;

        public CustomersController(ICustomerService customerServie)
        {
            _customerServie = customerServie;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {

            var result = _customerServie.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int customerId)
        {
            var result = _customerServie.GetById(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerServie.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerServie.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerServie.Update(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
