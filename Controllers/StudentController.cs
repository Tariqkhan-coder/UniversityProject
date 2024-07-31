using Microsoft.AspNetCore.Mvc;
using webapi.DataTransferModel;
using webapi.Interfaces;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _StudentServices;
        public StudentController(IStudent StudentServices)
        {
            _StudentServices = StudentServices;
        }
        [HttpGet("GetStudent")]
        public async Task<IActionResult> GetStudent()
        {
            var result = await _StudentServices.GetStudent();
            return Ok(result);
        }
        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent(CreateStudentVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _StudentServices.CreateStudent(model);
            return Ok(result);
        }
        [HttpDelete("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(long StudentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _StudentServices.DeleteStudent(StudentId);
            return Ok(result);
        }
        [HttpPost("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(UpdateStudentVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _StudentServices.UpdateStudent(model);
            return Ok(result);
        }
        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetStudents(long StudentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result=await _StudentServices.GetStudents(StudentId);
            return Ok(result);
        }
    }
}