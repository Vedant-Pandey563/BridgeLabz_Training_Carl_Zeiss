using BusinessLayer.Interfaces;
using DataBaseLayer.Interfaces;
using ModelLayer.DTOs.Courses;
using ModelLayer.Entities;

namespace BusinessLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public CourseService(ICourseRepository courseRepository, IEnrollmentRepository enrollmentRepository)
        {
            _courseRepository = courseRepository;
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<CourseDto> AddCourseAsync(CourseCreateDto dto)
        {
            var course = new Courses
            {
                CourseName = dto.CourseName,
                CourseDuration = dto.CourseDuration
            };

            var createdCourse = await _courseRepository.AddAsync(course);

            return new CourseDto
            {
                CourseId = createdCourse.CourseId,
                CourseName = createdCourse.CourseName,
                CourseDuration = createdCourse.CourseDuration
            };
        }

        public async Task<IReadOnlyList<CourseStudentDto>?> GetCourseStudentsAsync(int courseId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course is null)
            {
                return null;
            }

            var enrollments = await _enrollmentRepository.GetByCourseIdAsync(courseId);
            return enrollments
                .Select(enrollment => new CourseStudentDto
                {
                    StudentId = enrollment.StudentId,
                    StudentName = enrollment.Student.StudentName,
                    StudentEmail = enrollment.Student.StudentEmail
                })
                .ToList();
        }
    }
}
