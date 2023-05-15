using System.ComponentModel.DataAnnotations;

namespace Angular_Lab.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string name { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
    }
}
