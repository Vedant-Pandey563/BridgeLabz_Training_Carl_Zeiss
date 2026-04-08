using StudentApi.Models;

namespace StudentApi.Interfaces
{
    public interface IStudentRepository
    {
        //interface to fetch all students as obj
        Task<IEnumerable<Student>> GetAllAsync();

        //get sutdent by id interface
        Task<Student?> GetByIdAsync(int id);

        //create and return new student
        Task<Student> CreateAsync(Student student);

        //update student, true for succes false for not found
        Task<bool> UpdateAsync(int id, Student student);

        //delete student , true - delete fals - not gound
        Task<bool> DeleteAsync(int id);
    }
}
