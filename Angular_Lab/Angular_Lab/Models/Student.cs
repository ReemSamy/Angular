using System.ComponentModel.DataAnnotations;

namespace Angular_Lab.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int? Age { get; set; }
        public int? Department { get; set; }
        [StringLength(50)]
        public string email { get; set; } = string.Empty;
    }
}
