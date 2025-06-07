using Bank.Data;
using Bank.Dtos;
using Bank.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepoCustomer _context;
        public CustomerController(IRepoCustomer context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(CustomerDto customerDto)
        {
           var res = _context.Add(customerDto);
            if(res == true)
            {
                return Created();
            }
            return BadRequest();
        }
        [HttpGet("GetBYId")]
        public IActionResult Get(int id)
        {
            var res = _context.GetById(id);
            if(res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
    }
}
