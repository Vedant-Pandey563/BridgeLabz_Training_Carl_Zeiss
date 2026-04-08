using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Entities
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CourseName { get; set; } = string.Empty; 

        [Required]
        public int CourseDuration { get; set; }

        public ICollection<Enrollments> Enrollments { get; set; } = new List<Enrollments>();
        //reference to enrollements
    }
}
