using StudentApi.Interfaces;
using StudentApi.Models;
namespace StudentApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            // Currently just forwards call
            // Later: filtering, sorting, caching can be added here
            return await _repository.GetAllAsync();
        }
        // GET STUDENT BY ID
        public async Task<Student?> GetByIdAsync(int id)
        {
            // Example business validation
            if (id <= 0)
                return null; // invalid request

            return await _repository.GetByIdAsync(id);
        }

        // CREATE STUDENT
        public async Task<Student> CreateAsync(Student student)
        {
            // Business validation
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new ArgumentException("Student name is required");

            if (student.Age < 18)
                throw new ArgumentException("Student must be at least 18");

            // Call repository to insert into DB
            return await _repository.CreateAsync(student);
        }

        // UPDATE STUDENT
        public async Task<bool> UpdateAsync(int id, Student student)
        {
            // Validation
            if (id <= 0)
                return false;

            if (string.IsNullOrWhiteSpace(student.Name))
                throw new ArgumentException("Name cannot be empty");

            // Delegate to repository
            return await _repository.UpdateAsync(id, student);
        }

        // DELETE STUDENT
        public async Task<bool> DeleteAsync(int id)
        {
            if (id <= 0)
                return false;

            return await _repository.DeleteAsync(id);
        }

    }
}
