using MaxEdu.Domain.Entities.Lessons;
using MaxEdu.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxEdu.Domain.Entities.Groups
{
    public class Group
    {
        public Group()
        {
            StudentGroups = new HashSet<StudentGroup>();
            Lessons = new HashSet<Lesson>();
        }
        public int Id { get; set; }
        public string GroupName { get; set; }
        [ForeignKey(nameof(User))]
        public int TeacherId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User User { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
