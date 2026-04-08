using Dapper;
using DataBaseLayer.Interfaces;
using Microsoft.Data.SqlClient;
using ModelLayer.Entities;
using System.Data;

namespace DataBaseLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString;

        // Constructor: receives connection string from DI (Program.cs)
        public StudentRepository(string connectionString)
        {
            _connectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString))
                : connectionString;
        }

        // Creates SQL connection
        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);

        //  ADD STUDENT
        public async Task<Students> AddAsync(Students student)
        {
            const string sql = """
                INSERT INTO Students (StudentName, StudentEmail)
                OUTPUT INSERTED.StudentId
                VALUES (@StudentName, @StudentEmail);
                """;

            using var connection = CreateConnection();

            // explicitly open connection
            await connection.OpenAsync();

            // Execute query and return generated ID
            var studentId = await connection.ExecuteScalarAsync<int>(sql, student);

            student.StudentId = studentId;
            return student;
        }

        //  GET STUDENT BY ID
        public async Task<Students?> GetByIdAsync(int studentId)
        {
            const string sql = """
                SELECT StudentId, StudentName, StudentEmail
                FROM Students
                WHERE StudentId = @StudentId;
                """;

            using var connection = CreateConnection();

            // open connection
            await connection.OpenAsync();

            return await connection.QuerySingleOrDefaultAsync<Students>(
                sql,
                new { StudentId = studentId }
            );
        }
    }
}