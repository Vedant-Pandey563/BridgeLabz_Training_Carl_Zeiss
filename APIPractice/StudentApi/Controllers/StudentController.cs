using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;
using StudentApi.DTOs;
using StudentApi.Interfaces;


namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;

        // Inject Service
        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        // GET ALL
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAllAsync();

            // Map model to response dto
            var response = students.Select(s => new StudentResponseDto
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age
            });

            return Ok(response);
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _service.GetByIdAsync(id);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            var response = new StudentResponseDto
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age
            };

            return Ok(response);
        }

        // CREATE
        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateDto dto)
        {
            // Map dto to model
            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age
            };

            var created = await _service.CreateAsync(student);

            // Map model to response dto
            var response = new StudentResponseDto
            {
                Id = created.Id,
                Name = created.Name,
                Age = created.Age
            };

            return CreatedAtAction(nameof(GetById),
                new { id = response.Id }, response);
        }

        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentUpdateDto dto)
        {
            var student = new Student
            {
                Name = dto.Name,
                Age = dto.Age
            };

            var updated = await _service.UpdateAsync(id, student);

            if (!updated)
                return NotFound(new { message = "Student not found" });

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Student not found" });

            return NoContent();
        }
    }
}