using Microsoft.EntityFrameworkCore;

namespace AngularLab.Models
{
    public class SchoolContextBase
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=School;Trusted_Connection=True;encrypt=false");
            }
        }
    }
}