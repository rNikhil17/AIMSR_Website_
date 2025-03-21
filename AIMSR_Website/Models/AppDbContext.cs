using Microsoft.EntityFrameworkCore;

namespace AIMSR_Website.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Results> Results { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
    }
}
