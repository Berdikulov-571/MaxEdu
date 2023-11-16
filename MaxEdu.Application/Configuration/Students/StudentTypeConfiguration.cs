using MaxEdu.Domain.Entities.Groups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaxEdu.Application.Configuration.Students
{
    public class StudentTypeConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.StudentGroups);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.StudentGroups)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
