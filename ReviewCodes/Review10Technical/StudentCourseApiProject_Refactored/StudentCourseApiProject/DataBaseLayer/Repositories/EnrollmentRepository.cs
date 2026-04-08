using Dapper;
using DataBaseLayer.Interfaces;
using Microsoft.Data.SqlClient;
using ModelLayer.Entities;
using System.Data;

namespace DataBaseLayer.Repositories
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly string _connectionString;

        public EnrollmentRepository(string connectionString)
        {
            _connectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString))
                : connectionString;
        }

        private SqlConnection CreateConnection() => new SqlConnection(_connectionString);

        //  ADD ENROLLMENT
        public async Task<Enrollments> AddAsync(Enrollments enrollment)
        {
            const string sql = """
                INSERT INTO Enrollments (StudentId, CourseId)
                OUTPUT INSERTED.EnrollmentId
                VALUES (@StudentId, @CourseId);
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            var enrollmentId = await connection.ExecuteScalarAsync<int>(sql, enrollment);

            enrollment.EnrollmentId = enrollmentId;
            return enrollment;
        }

        // CHECK IF ENROLLMENT EXISTS
        public async Task<bool> ExistsAsync(int studentId, int courseId)
        {
            const string sql = """
                SELECT CAST(CASE WHEN EXISTS (
                    SELECT 1
                    FROM Enrollments
                    WHERE StudentId = @StudentId AND CourseId = @CourseId
                ) THEN 1 ELSE 0 END AS bit);
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            return await connection.ExecuteScalarAsync<bool>(
                sql,
                new { StudentId = studentId, CourseId = courseId }
            );
        }

        // GET COURSES OF A STUDENT
        public async Task<IReadOnlyList<Enrollments>> GetByStudentIdAsync(int studentId)
        {
            const string sql = """
                SELECT e.EnrollmentId, e.StudentId, e.CourseId,
                       c.CourseId AS CourseId2, c.CourseName, c.CourseDuration
                FROM Enrollments e
                INNER JOIN Courses c ON c.CourseId = e.CourseId
                WHERE e.StudentId = @StudentId;
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            //  Multi-mapping: Enrollments + Courses
            var result = await connection.QueryAsync<Enrollments, Courses, Enrollments>(
                sql,
                (enrollment, course) =>
                {
                    enrollment.Course = course; // map course into enrollment
                    return enrollment;
                },
                new { StudentId = studentId },

                //  match alias "CourseId2"
                splitOn: "CourseId2"
            );

            return result.ToList();
        }

        //  GET STUDENTS OF A COURSE
        public async Task<IReadOnlyList<Enrollments>> GetByCourseIdAsync(int courseId)
        {
            const string sql = """
                SELECT e.EnrollmentId, e.StudentId, e.CourseId,
                       s.StudentId AS StudentId2, s.StudentName, s.StudentEmail
                FROM Enrollments e
                INNER JOIN Students s ON s.StudentId = e.StudentId
                WHERE e.CourseId = @CourseId;
                """;

            using var connection = CreateConnection();

            await connection.OpenAsync(); 

            var result = await connection.QueryAsync<Enrollments, Students, Enrollments>(
                sql,
                (enrollment, student) =>
                {
                    enrollment.Student = student; // map student
                    return enrollment;
                },
                new { CourseId = courseId },

                //   match alias "StudentId2"
                splitOn: "StudentId2"
            );

            return result.ToList();
        }
    }
}