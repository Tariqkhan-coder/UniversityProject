    using Microsoft.AspNetCore.Mvc;
    using webapi.DataTransferModel;
    using webapi.Interfaces;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _TeacherServices;
        public TeacherController(ITeacher TeacherServices)
        {
            _TeacherServices = TeacherServices;
        }
        [HttpGet("GetTeacher")]
        public async Task<IActionResult> GetTeacher()
        {
            var result = await _TeacherServices.GetTeacher();
            return Ok(result);
        }
        [HttpPost("CreateTeacher")]
        public async Task<IActionResult> CreateTeacher(CreateTeacherVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _TeacherServices.CreateTeacher(model);
            return Ok(result);
        }
        [HttpDelete("DeleteTeacher")]
        public async Task<IActionResult> DeleteTeacher(long TeacherId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _TeacherServices.DeleteTeacher(TeacherId);
            return Ok(result);
        }
        [HttpPost("UpdateTeacher")]
            public async Task<IActionResult> UpdateTeacher(UpdateTeacherVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result=await _TeacherServices.UpdateTeacher(model);
            return Ok(result);
        }
        [HttpGet("GetTeachers")]
        public async Task<IActionResult> GetTeachers(long TeacherId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result=await _TeacherServices.GetTeachers(TeacherId);
            return Ok(result);

        }
    }
}