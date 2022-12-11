using System.ComponentModel.DataAnnotations;

namespace NewStudiesAPI.Entities
{
    public class University
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Type { get; set; }

        public virtual Address UniversityAdress { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
}
