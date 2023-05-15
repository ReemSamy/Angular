using Microsoft.EntityFrameworkCore;

namespace AngularLab.Models
{
    public class SchoolContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;encrypt=false");
            }
        }

    }
}
