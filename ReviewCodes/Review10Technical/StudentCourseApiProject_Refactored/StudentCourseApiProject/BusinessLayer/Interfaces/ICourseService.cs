using ModelLayer.DTOs.Courses;

namespace BusinessLayer.Interfaces
{
    public interface ICourseService
    {
        Task<CourseDto> AddCourseAsync(CourseCreateDto dto);
        Task<IReadOnlyList<CourseStudentDto>?> GetCourseStudentsAsync(int courseId);
    }
}
