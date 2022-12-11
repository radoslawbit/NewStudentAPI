using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewStudentAPI.Models;
using NewStudentAPI.Services;
using NewStudiesAPI.Entities;
using NewStudiesAPI.Models;

namespace NewStudentAPI.Controllers
{
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // tutaj jest problem wynikający z połączenia SSL

        [HttpGet]
        public ActionResult<IEnumerable<StudentDto>> GetAll()
        {
            var studentsDtos = _studentService.GetAll();

            return Ok(studentsDtos);
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDto> Get([FromRoute] int id)
        {
            var student = _studentService.GetById(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpPost]
        public ActionResult CreateStudent([FromBody] CreateStudentDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = _studentService.Create(dto);

            return Created($"/api/student/{id}", null);
        }
    }
}
