using System.ComponentModel.DataAnnotations;

namespace NewStudentAPI.Models
{
    public class CreateStudentDto
    {
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

        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(50)]
        public string Street { get; set; }
        [MaxLength(4)]
        public string HouseNumber { get; set; }
        [MaxLength(30)]
        public string Country { get; set; }
        [MaxLength(8)]
        public string PostalCode { get; set; }
        [MaxLength(50)]
        public string UniversityName { get; set; }
    }
}
