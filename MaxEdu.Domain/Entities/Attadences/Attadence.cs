using MaxEdu.Domain.Entities.Lessons;
using MaxEdu.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxEdu.Domain.Entities.Attendances
{
    public class Attadence
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int StudentId { get; set; }
        [ForeignKey(nameof(Lesson))]
        public int LessonId { get; set; }
        public bool IsParticipated { get; set; }
        public Lesson Lesson { get; set; }
        public User User { get; set; }
    }
}