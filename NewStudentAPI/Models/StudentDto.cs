using NewStudiesAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace NewStudiesAPI.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public StudentState State { get; set; }
        public int IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public string UniversityName { get; set; }

        public List<SubjectDto> Subjects { get; set; }
    }
}
