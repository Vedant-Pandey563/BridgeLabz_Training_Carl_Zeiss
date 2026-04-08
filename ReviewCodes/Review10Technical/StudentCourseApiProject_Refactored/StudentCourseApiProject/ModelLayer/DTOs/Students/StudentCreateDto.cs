using System.ComponentModel.DataAnnotations;

namespace ModelLayer.DTOs.Students
{
    public class StudentCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string StudentName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string StudentEmail { get; set; } = string.Empty;
    }
}
