using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTOs.Enrollments;

namespace StudentCourseApiProject.Controllers
{
    [ApiController]

    //ROUTING
    [Route("api/[controller]")]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentsController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        // POST: api/enrollments
        [HttpPost]
        public async Task<ActionResult<EnrollmentDto>> EnrollStudent(EnrollmentCreateDto dto)
        {
            var result = await _enrollmentService.EnrollStudentAsync(dto);

            if (result is null)
            {
                return BadRequest("Enrollment failed");
            }

            return Ok(result);
        }
    }
}