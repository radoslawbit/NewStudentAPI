using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace NewStudiesAPI.Entities
{
    public class StudiesDbContext : DbContext
    {

        public StudiesDbContext(DbContextOptions<StudiesDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<StudentState> StudentStates { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(eb =>
            {
                eb.Property(x => x.Email).HasMaxLength(50);
                eb.Property(x => x.PersonalId).HasMaxLength(10).HasColumnName("Personal ID");
                eb.Property(x => x.FirstName).HasMaxLength(25).HasColumnName("First name");
                eb.Property(x => x.LastName).HasMaxLength(25).HasColumnName("Last name");
                eb.Property(x => x.IndexNumber).HasMaxLength(6).HasColumnName("Index number");
                eb.Property(x => x.StartDate).HasDefaultValueSql("getutcdate()");

                eb.HasOne(x => x.StudentAddress).WithOne(s => s.Student).HasForeignKey<Address>(s => s.StudentId);
                eb.HasMany(x => x.Subjects).WithOne(s => s.Student).HasForeignKey(s => s.StudentId);
                eb.HasOne(x => x.State).WithMany().HasForeignKey(x => x.StateId);
            });

            modelBuilder.Entity<Lecturer>(eb =>
            {
                eb.Property(x => x.Email).HasMaxLength(50);
                eb.Property(x => x.PersonalId).HasMaxLength(10).HasColumnName("Personal ID");
                eb.Property(x => x.FirstName).HasMaxLength(25).HasColumnName("First name");
                eb.Property(x => x.LastName).HasMaxLength(25).HasColumnName("Last name");
                eb.Property(x => x.AcademicTitle).HasMaxLength(20).HasColumnName("Academic title");

                eb.HasOne(x => x.LecturerAddress).WithOne(l => l.Lecturer).HasForeignKey<Address>(l => l.LecturerId);
                eb.HasMany(x => x.Subjects).WithOne(l => l.Lecturer).HasForeignKey(l => l.LecturerId);
            });

            modelBuilder.Entity<University>(
                eb =>
                {
                    eb.Property(x => x.Name).HasMaxLength(50);
                    eb.Property(x => x.Description).HasMaxLength(300);
                    eb.Property(x => x.Type).HasMaxLength(20);


                    eb.HasOne(x => x.UniversityAdress).WithOne(u => u.University).HasForeignKey<Address>(u => u.UniversityId);
                    eb.HasMany(x => x.Subjects).WithOne(u => u.University).HasForeignKey(s => s.UniversityId);
                });

            modelBuilder.Entity<Address>(eb =>
            {
                eb.Property(x => x.Street).HasMaxLength(50);
                eb.Property(x => x.City).HasMaxLength(30);
                eb.Property(x => x.HouseNumber).HasMaxLength(4).HasColumnName("House number");
                eb.Property(x => x.PostalCode).HasMaxLength(8).HasColumnName("Postal code");
                eb.Property(x => x.Country).HasMaxLength(30);
            });

            modelBuilder.Entity<Subject>(
               eb =>
               {
                   eb.Property(x => x.Name).HasMaxLength(50);
                   eb.Property(x => x.Description).HasMaxLength(300);
               });

            modelBuilder.Entity<StudentState>(eb =>
            {
                eb.Property(x => x.Value).IsRequired().HasMaxLength(50);
                eb.HasData(new StudentState() { Id = 1, Value = "Finished" },
                    new StudentState { Id = 2, Value = "Unfinished" },
                    new StudentState { Id = 3, Value = "Failed" });
            });

        }
    }
}
