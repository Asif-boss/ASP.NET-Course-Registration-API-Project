using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        StudentService service;
        public StudentController(StudentService service) { 
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
        public IActionResult Create(StudentDTO c) { 
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
        public IActionResult Update(StudentDTO c)
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
    }
}

