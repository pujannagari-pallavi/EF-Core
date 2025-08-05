using Microsoft.EntityFrameworkCore;

namespace CodeFirst1.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        //called during migration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-K254T03;Database=DbEfCore;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
