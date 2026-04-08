using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTOs.Courses;

namespace StudentCourseApiProject.Controllers
{
    [ApiController]

    //  ROUTING
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // POST: api/courses
        [HttpPost]
        public async Task<ActionResult<CourseDto>> AddCourse(CourseCreateDto dto)
        {
            var course = await _courseService.AddCourseAsync(dto);
            return Ok(course);
        }

        // GET: api/courses/id/students
        [HttpGet("{id:int}/students")]
        public async Task<ActionResult<IReadOnlyList<CourseStudentDto>>> GetCourseStudents(int id)
        {
            var students = await _courseService.GetCourseStudentsAsync(id);

            if (students is null || !students.Any()) //  check
            {
                return NotFound();
            }

            return Ok(students);
        }
    }
}