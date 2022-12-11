using System.ComponentModel.DataAnnotations;

namespace NewStudiesAPI.Entities
{
    public class Lecturer
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string AcademicTitle { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string LastName { get; set; }
        [MaxLength(10)]
        public int PersonalId { get; set; }
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual Address LecturerAddress { get; set; }
        public virtual University LecturerUniversity { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
}
