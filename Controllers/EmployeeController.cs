using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Models;
using webapi.Services;
using webapi.University_context;

namespace webapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _EmployeeServices;
        private readonly UniversityContext _universityContext;
        public EmployeeController(IEmployee employeeServices, UniversityContext universityContext)
        {
            _EmployeeServices = employeeServices;
            _universityContext = universityContext;
        }
        [HttpGet("GetEmployee")]
        public async Task<IActionResult> GetEmployee(long EmpId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _EmployeeServices.GetEmployee(EmpId);
            return Ok(result);
        }
        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _EmployeeServices.CreateEmployee(model);
            return Ok(result);

        }
    }
}
    