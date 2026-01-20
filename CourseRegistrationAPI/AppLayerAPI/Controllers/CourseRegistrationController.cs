using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseRegistrationController : ControllerBase
    {
        CourseRegistrationService service;
        public CourseRegistrationController(CourseRegistrationService service) { 
            this.service = service;
        }
        
        // CRUD
        [HttpGet("all")]
        public IActionResult All() {
            var data = service.Get();
            return Ok(data);
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = service.Get(id);
            return Ok(data);
        }
        [HttpPost("create")]
        public IActionResult Create(CourseRegistrationDTO c) { 
            var res = service.Create(c);
            if (res == true)
            {
                return Ok(res);
            }
            else {
                return BadRequest(res);
            }
        }
        [HttpPost("update")]
        public IActionResult Update(CourseRegistrationDTO c)
        {
            var res = service.Update(c);
            if (res == true)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
        }
        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var res = service.Delete(id);
            if (res == true)
            {
                return Ok(res);
            }
            else
            {
                return BadRequest(res);
            }
        }
        
        // Unique
        [HttpPost("cancel/{studentId}/{courseId}")]
        public IActionResult CancelRegistration(int studentId, int courseId)
        {
            return Ok(service.CancelRegistration(studentId,  courseId));
        }
        
        [HttpGet("student/{id}")]
        public IActionResult GetStudentRegistrations(int id)
        {
            return Ok(service.GetStudentRegistrations(id));
        }
        
        [HttpGet("course/{id}")]
        public IActionResult GetStudentsList(int id)
        {
            return Ok(service.GetStudentRegistrations(id));
        }
    }
}

