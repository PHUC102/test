using System.ComponentModel.DataAnnotations;

namespace testbaithi.Models
{
    public class Student
    {
        [Key]
        public string? StudentId { get; set; }

        [Required]
        [Display(Name = "Tên Sinh Viên")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Tuổi")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Ngày Sinh")]
        public DateTime BirthDate { get; set; }
        // Thêm thuộc tính Navigation cho mối quan hệ với Course
    public ICollection<Course> Courses { get; set; } = new List<Course>(); // Khởi tạo ICollection ở đây
}
}
