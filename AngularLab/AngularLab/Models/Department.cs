using System.ComponentModel.DataAnnotations;

namespace AngularLab.Models
{
    public class Department
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string name { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty;
    }
}
