using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace NewStudiesAPI.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public StudentState State { get; set; }
        [MaxLength(6)]
        public int IndexNumber { get; set; }
        [MaxLength(10)]
        public int PersonalId { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Address StudentAddress { get; set; }
        public virtual University StudentUniversity { get; set; }
        public virtual List<Subject> Subjects { get; set; }


    }
}
