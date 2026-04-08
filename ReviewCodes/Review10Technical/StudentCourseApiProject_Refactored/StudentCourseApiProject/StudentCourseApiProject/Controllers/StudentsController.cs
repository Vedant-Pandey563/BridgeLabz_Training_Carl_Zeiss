using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTOs.Students;

namespace StudentCourseApiProject.Controllers
{
    [ApiController]

    // ROUTING
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // POST: api/students
        [HttpPost]
        public async Task<ActionResult<StudentDto>> AddStudent(StudentCreateDto dto)
        {
            var student = await _studentService.AddStudentAsync(dto);
            return Ok(student);
        }

        // GET: api/students/id/courses
        [HttpGet("{id:int}/courses")]
        public async Task<ActionResult<IReadOnlyList<StudentCourseDto>>> GetStudentCourses(int id)
        {
            var courses = await _studentService.GetStudentCoursesAsync(id);

            //  check 
            if (courses is null || !courses.Any())
            {
                return NotFound();
            }

            return Ok(courses);
        }
    }
}