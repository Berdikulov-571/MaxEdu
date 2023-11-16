using MaxEdu.Domain.Entities.Attendances;
using MaxEdu.Domain.Entities.Groups;
using MaxEdu.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MaxEdu.Domain.Entities.Users
{
    public class User
    {
        public User()
        {
            Attendances = new HashSet<Attadence>();
            Groups = new HashSet<Group>();
            StudentGroups = new HashSet<StudentGroup>();
        }
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public string Address { get; set; }
        public string PasswordHash { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Attadence> Attendances { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}