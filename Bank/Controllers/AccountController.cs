using Bank.Dtos;
using Bank.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo _context;
        public AccountController(IAccountRepo context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(AccountDtoPost accountDtoPost)
        {
            var res = _context.Post(accountDtoPost);
            if (res == true)
            {
                return Created();
            }
            return BadRequest();
        }
    }
}
