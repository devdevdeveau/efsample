using Microsoft.EntityFrameworkCore;

namespace EFSample1
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Student { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userEntity = modelBuilder.Entity<User>();
            userEntity.HasKey(u => u.UserId);
            userEntity.HasOne(u => u.Student)
                .WithOne(s => s.User);

            var studentEntity = modelBuilder.Entity<Student>();
            studentEntity.HasKey(s => s.StudentId);
            studentEntity.HasOne(s => s.User)
                .WithOne(u => u.Student);

            base.OnModelCreating(modelBuilder);
        }
    }
}