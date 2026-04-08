using Dapper;
using DataBaseLayer.Interfaces;
using Microsoft.Data.SqlClient;
using ModelLayer.Entities;
using System.Data;

namespace DataBaseLayer.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly string _connectionString;

        public CourseRepository(string connectionString)
        {
            _connectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString))
                : connectionString;
        }

        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);
        //private IDbConnection CreateConnection() => new SqlConnection(_connectionString); idbconn not support openasync

        // ADD COURSE
        public async Task<Courses> AddAsync(Courses course)
        {
            const string sql = """
                INSERT INTO Courses (CourseName, CourseDuration)
                OUTPUT INSERTED.CourseId
                VALUES (@CourseName, @CourseDuration);
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            var courseId = await connection.ExecuteScalarAsync<int>(sql, course);

            course.CourseId = courseId;
            return course;
        }

        //  GET COURSE BY ID
        public async Task<Courses?> GetByIdAsync(int courseId)
        {
            const string sql = """
                SELECT CourseId, CourseName, CourseDuration
                FROM Courses
                WHERE CourseId = @CourseId;
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            return await connection.QuerySingleOrDefaultAsync<Courses>(
                sql,
                new { CourseId = courseId }
            );
        }
    }
}