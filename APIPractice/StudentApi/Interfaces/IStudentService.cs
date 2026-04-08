using StudentApi.Models;

namespace StudentApi.Interfaces
{
    public interface IStudentService
    {
        // Get all students 
        Task<IEnumerable<Student>> GetAllAsync();

        // Get student by ID
        Task<Student?> GetByIdAsync(int id);

        // Create student
        Task<Student> CreateAsync(Student student);

        // Update student 
        Task<bool> UpdateAsync(int id, Student student);

        // Delete student
        Task<bool> DeleteAsync(int id);
    }
}
