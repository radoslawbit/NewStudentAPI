using NewStudentAPI.Models;
using NewStudiesAPI.Models;

namespace NewStudentAPI.Services
{
    public interface IStudentService
    {
        int Create(CreateStudentDto dto);
        IEnumerable<StudentDto> GetAll();
        StudentDto GetById(int id);
    }
}