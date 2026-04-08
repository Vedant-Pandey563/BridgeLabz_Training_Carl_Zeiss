using ModelLayer.Entities;

namespace DataBaseLayer.Interfaces
{
    public interface IStudentRepository
    {
        Task<Students> AddAsync(Students student);
        Task<Students?> GetByIdAsync(int studentId);
    }
}
