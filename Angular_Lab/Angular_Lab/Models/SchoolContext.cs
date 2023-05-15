using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Angular_Lab.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() { }
        public SchoolContext(DbContextOptions<SchoolContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;encrypt=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
