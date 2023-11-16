using MaxEdu.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxEdu.Domain.Entities.Groups
{
    public class StudentGroup
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public int StudentId { get; set; }
        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsPayed { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
    }
}
