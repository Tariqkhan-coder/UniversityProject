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
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _DepartmentServices;
        private readonly UniversityContext _universityContext;
        public DepartmentController(IDepartment DepartmentServices, UniversityContext universityContext)
        {
            _DepartmentServices = DepartmentServices;
            _universityContext = universityContext;
        }
        [HttpPost("CreateDepartment")]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _DepartmentServices.CreateDepartment(model);
            return Ok(result);
        }

        [HttpPost("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment(UpdateDepartmentVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _DepartmentServices.UpdateDepartment(model);
            return Ok(result);

        }
        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment()
        {
            var result = await _DepartmentServices.GetDepartment();
            return Ok(result);
        }
        [HttpDelete("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(long DepartmentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _DepartmentServices.DeleteDepartment(DepartmentId);
            return Ok(result);
        }

        [HttpGet("GetDepartments")]
        public async Task<IEnumerable<Department>>GetDepartments(long DepartmentId)
        {
            var dvm = await _universityContext.DepartmentDetails.AsNoTracking()
                                                                    .Where(x => x.DepartmentId == DepartmentId)
                                                                    .ToListAsync();
            return dvm.ToList();
        }
    }
}
