using ModelLayer.DTOs.Students;

namespace BusinessLayer.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDto> AddStudentAsync(StudentCreateDto dto);
        Task<IReadOnlyList<StudentCourseDto>?> GetStudentCoursesAsync(int studentId);
    }
}
