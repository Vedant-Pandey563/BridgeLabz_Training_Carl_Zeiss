using System.ComponentModel.DataAnnotations;

namespace ModelLayer.DTOs.Courses
{
    public class CourseCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; } = string.Empty;

        [Required]
        public int CourseDuration { get; set; }
    }
}
