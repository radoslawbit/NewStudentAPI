using System.ComponentModel.DataAnnotations;

namespace NewStudiesAPI.Entities
{
    public class Address
    {
        public int Id { get; set; }
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

        public int? StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int? LecturerId { get; set; }
        public virtual Lecturer? Lecturer { get; set; }
        public int? UniversityId { get; set; }
        public virtual University? University { get; set; }
    }
}
