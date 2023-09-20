namespace StudentAPIProject.Data
{
    using Microsoft.EntityFrameworkCore;
    using StudentAPIProject.Models;

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
