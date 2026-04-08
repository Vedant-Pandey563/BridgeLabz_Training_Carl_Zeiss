using ModelLayer.DTOs.Enrollments;

namespace ModelLayer.Results
{
    // to return result of enrollment query
    public enum EnrollmentStatus
    {
        Success,
        StudentNotFound,
        CourseNotFound,
        AlreadyEnrolled
    }

    public class EnrollmentResult
    {
        public EnrollmentStatus Status { get; set; }
        public EnrollmentDto? Enrollment { get; set; }
    }
}
