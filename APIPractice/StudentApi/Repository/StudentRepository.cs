using Dapper;
using StudentApi.Data;
using StudentApi.Interfaces;
using StudentApi.Models;
namespace StudentApi.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DapperContext _context;

        public StudentRepository(DapperContext context)
        {
            _context = context;
        }

        //get all
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var query = "Select * From Students;";

            using var connection = _context.CreateConnection();
            var students = await connection.QueryAsync<Student>(query);

            return students;
        }


        //get by id
        public async Task<Student?> GetByIdAsync(int id)
        {
            var query = "Select * from Students Where Id = @Id;";
            using var connection = _context.CreateConnection();

            var student = await connection.QueryFirstOrDefaultAsync<Student>(
                           query,
                           new { Id = id } 
                       );

            return student;
        }

        //create
        public async Task<Student> CreateAsync(Student student)
        {
            var query = @"Insert Into Students(Name,Age)
                          Values (@Name,@Age);
                          Select Cast(Scope_Identity() as int );";

            using var connection = _context.CreateConnection();

            var id = await connection.ExecuteScalarAsync<int>(query,student);

            student.Id = id;
            return student;
        }

        public async Task<bool> UpdateAsync(int id, Student student)
        {

            var query = @"Update Students
                        Set Name = @Name, Age = @Age
                        Where Id = @Id;";

            using var connection = _context.CreateConnection();
            var rowsAffected = await connection.ExecuteAsync(
                            query,
                            new
                            {
                                student.Name,
                                student.Age,
                                Id = id
                            }
                        );

            return rowsAffected >0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var query = "Delete from Students where Id =@Id";
            using var connection = _context.CreateConnection();
            var rowsAffected = await connection.ExecuteAsync(
                query,
                new { Id = id }
            );

            return rowsAffected > 0;
        }
    }
}