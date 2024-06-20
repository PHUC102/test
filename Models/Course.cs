using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace testbaithi.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Tên Khóa Học")]
        public string? CourseName { get; set; }

        [Required]
        [Display(Name = "Mã Sinh Viên")]
        public string? StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student? Student { get; set; }
          
    
    }
}
