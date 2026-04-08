using ModelLayer.Entities;

namespace DataBaseLayer.Interfaces
{
    public interface ICourseRepository
    {
        Task<Courses> AddAsync(Courses course);
        Task<Courses?> GetByIdAsync(int courseId);
    }
}
