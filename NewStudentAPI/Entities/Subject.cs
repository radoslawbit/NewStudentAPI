using System.ComponentModel.DataAnnotations;

namespace NewStudiesAPI.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }


        public int UniversityId { get; set; }
        public virtual University University { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
    }
}
