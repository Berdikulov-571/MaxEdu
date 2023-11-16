using MaxEdu.Domain.Entities.Attendances;
using MaxEdu.Domain.Entities.Groups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxEdu.Domain.Entities.Lessons
{
    public class Lesson
    {
        public Lesson()
        {
            Attadances = new HashSet<Attadence>();
        }
        [Key]
        public int Id { get; set; }
        public string LessonTheme { get; set; }
        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public DateTime StartedDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public Group Group { get; set; }
        public ICollection<Attadence> Attadances { get; set; }
    }
}
