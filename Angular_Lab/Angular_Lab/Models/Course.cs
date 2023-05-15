using System.ComponentModel.DataAnnotations;

namespace Angular_Lab.Models
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
        public int LecHour { get; set; }
        public int LabHour { get; set; }
    }
}
