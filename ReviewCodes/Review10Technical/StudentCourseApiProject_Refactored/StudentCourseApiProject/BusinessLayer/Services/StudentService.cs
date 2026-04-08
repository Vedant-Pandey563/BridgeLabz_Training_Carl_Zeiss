using BusinessLayer.Interfaces;
using DataBaseLayer.Interfaces;
using ModelLayer.DTOs.Students;
using ModelLayer.Entities;

namespace BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public StudentService(IStudentRepository studentRepository, IEnrollmentRepository enrollmentRepository)
        {
            _studentRepository = studentRepository;
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<StudentDto> AddStudentAsync(StudentCreateDto dto)
        {
            var student = new Students
            {
                StudentName = dto.StudentName,
                StudentEmail = dto.StudentEmail
            };

            var createdStudent = await _studentRepository.AddAsync(student);

            return new StudentDto
            {
                StudentId = createdStudent.StudentId,
                StudentName = createdStudent.StudentName,
                StudentEmail = createdStudent.StudentEmail
            };
        }

        public async Task<IReadOnlyList<StudentCourseDto>?> GetStudentCoursesAsync(int studentId)
        {
            var student = await _studentRepository.GetByIdAsync(studentId);
            if (student is null)
            {
                return null;
            }

            var enrollments = await _enrollmentRepository.GetByStudentIdAsync(studentId);
            return enrollments
                .Select(enrollment => new StudentCourseDto
                {
                    CourseId = enrollment.CourseId,
                    CourseName = enrollment.Course.CourseName,
                    CourseDuration = enrollment.Course.CourseDuration
                })
                .ToList();
        }
    }
}
