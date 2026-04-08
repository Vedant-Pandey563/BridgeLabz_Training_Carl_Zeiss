using ModelLayer.DTOs.Enrollments;
using ModelLayer.Results;

namespace BusinessLayer.Interfaces
{
    public interface IEnrollmentService
    {
        Task<EnrollmentResult> EnrollStudentAsync(EnrollmentCreateDto dto);
    }
}
