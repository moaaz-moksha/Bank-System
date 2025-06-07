using Bank.Dtos;
using Bank.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchRepo _context;
        public BranchController(IBranchRepo context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(BranchDtoPost branchDtoPost)
        {
            var res = _context.PostBranch(branchDtoPost);
            if (res == true)
            {
                return Created();
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Update(int id, BranchDtoUpdate dto)
        {
            var res = _context.Update(id ,  dto );
            if (res == true)
            {
                return Ok(res);
            }
            return BadRequest();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _context.GettAll();
            if (res != null)
            {
                return Ok(res);
            }
            return BadRequest();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var res = _context.Delete(id);
            if (res == true)
            {
                return Ok(res);
            }
            return BadRequest();
        }
    }
}
