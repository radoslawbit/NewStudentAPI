using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NewStudentAPI.Models;
using NewStudiesAPI.Entities;
using NewStudiesAPI.Models;

namespace NewStudentAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudiesDbContext _dbContext;
        private readonly IMapper _mapper;

        public StudentService(StudiesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public StudentDto GetById(int id)
        {
            var student = _dbContext
                .Students
                .Include(s => s.StudentAddress)
                .Include(s => s.Subjects)
                .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return null;
            }

            var result = _mapper.Map<StudentDto>(student);
            return result;
        }


        public IEnumerable<StudentDto> GetAll()
        {
            var students = _dbContext
              .Students
              .Include(s => s.StudentAddress)
              .Include(s => s.Subjects)
              .ToList();

            var studentsDtos = _mapper.Map<List<StudentDto>>(students);

            return studentsDtos;
        }


        public int Create(CreateStudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();

            return student.Id;
        }
    }
}
