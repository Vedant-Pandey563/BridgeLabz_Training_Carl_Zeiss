using ModelLayer.Entities;

namespace DataBaseLayer.Interfaces
{
    public interface IEnrollmentRepository
    {
        Task<Enrollments> AddAsync(Enrollments enrollment);
        Task<bool> ExistsAsync(int studentId, int courseId);
        Task<IReadOnlyList<Enrollments>> GetByStudentIdAsync(int studentId);
        Task<IReadOnlyList<Enrollments>> GetByCourseIdAsync(int courseId);
    }
}
