using MaxEdu.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaxEdu.Application.Configuration.Users
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName)
                .IsRequired();

            builder.HasMany(x => x.StudentGroups)
                .WithOne(x => x.User);

            builder.HasMany(x => x.Groups)
                .WithOne(x => x.User);

            builder.HasMany(x => x.Attendances)
                .WithOne(x => x.User);
        }
    }
}