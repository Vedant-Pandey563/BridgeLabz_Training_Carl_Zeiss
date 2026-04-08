using BusinessLayer.Interfaces;
using DataBaseLayer.Interfaces;
using ModelLayer.DTOs.Enrollments;
using ModelLayer.Entities;
using ModelLayer.Results;

namespace BusinessLayer.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentService(
            IStudentRepository studentRepository,
            ICourseRepository courseRepository,
            IEnrollmentRepository enrollmentRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _enrollmentRepository = enrollmentRepository;
        }

        public async Task<EnrollmentResult> EnrollStudentAsync(EnrollmentCreateDto dto)
        {
            var student = await _studentRepository.GetByIdAsync(dto.StudentId);
            if (student is null)
            {
                return new EnrollmentResult { Status = EnrollmentStatus.StudentNotFound };
            }

            var course = await _courseRepository.GetByIdAsync(dto.CourseId);
            if (course is null)
            {
                return new EnrollmentResult { Status = EnrollmentStatus.CourseNotFound };
            }

            if (await _enrollmentRepository.ExistsAsync(dto.StudentId, dto.CourseId))
            {
                return new EnrollmentResult { Status = EnrollmentStatus.AlreadyEnrolled };
            }

            var enrollment = new Enrollments
            {
                StudentId = dto.StudentId,
                CourseId = dto.CourseId
            };

            var created = await _enrollmentRepository.AddAsync(enrollment);

            return new EnrollmentResult
            {
                Status = EnrollmentStatus.Success,
                Enrollment = new EnrollmentDto
                {
                    EnrollmentId = created.EnrollmentId,
                    StudentId = created.StudentId,
                    CourseId = created.CourseId
                }
            };
        }
    }
}
