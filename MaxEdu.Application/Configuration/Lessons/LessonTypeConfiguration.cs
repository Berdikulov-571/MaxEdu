using MaxEdu.Domain.Entities.Lessons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaxEdu.Application.Configuration.Lessons
{
    public class LessonTypeConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.LessonTheme)
                .IsRequired();

            builder.Property(x => x.StartedDateTime).IsRequired(true);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.Lessons);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.Lessons);
        }
    }
}
