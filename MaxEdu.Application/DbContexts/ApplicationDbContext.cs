using MaxEdu.Domain.Entities.Attendances;
using MaxEdu.Domain.Entities.Groups;
using MaxEdu.Domain.Entities.Lessons;
using MaxEdu.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MaxEdu.Application.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Attadence> Attadences { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
        }
    }
}
