using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Interfaces;
using webapi.University_context;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _UserServices;
        private readonly UniversityContext _UniversityContext;
       // private readonly UniversityContext universityContext;
        public UserController(IUser UserServices, UniversityContext universityContext)
        {
            _UserServices = UserServices;
            _UniversityContext = universityContext;
        }
        [HttpGet("Verify")]
        public async Task<IActionResult> VerifyEmail(string Email)
        {

            var user = await _UniversityContext.Userdetails.FirstOrDefaultAsync(u => u.Email == Email);
                if (user == null)
                {
                    return BadRequest("User not Found");
                }

               
            await _UniversityContext.SaveChangesAsync();
                return Ok("verified");
          
        }
    }
}
