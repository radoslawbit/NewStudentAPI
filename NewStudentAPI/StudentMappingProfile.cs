using AutoMapper;
using NewStudentAPI.Models;
using NewStudiesAPI.Entities;
using NewStudiesAPI.Models;

namespace NewStudentAPI
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Student, StudentDto>()
                .ForMember(m => m.City, c => c.MapFrom(a => a.StudentAddress.City))
            .ForMember(m => m.Street, c => c.MapFrom(a => a.StudentAddress.Street))
            .ForMember(m => m.HouseNumber, c => c.MapFrom(a => a.StudentAddress.HouseNumber))
            .ForMember(m => m.Country, c => c.MapFrom(a => a.StudentAddress.Country))
            .ForMember(m => m.PostalCode, c => c.MapFrom(a => a.StudentAddress.PostalCode))
            .ForMember(m => m.UniversityName, c => c.MapFrom(u => u.StudentUniversity.Name))
            .ForMember(m => m.Subjects, c => c.MapFrom(s => s.Subjects));

            CreateMap<CreateStudentDto, Student>()
                .ForMember(s => s.StudentAddress, c => c.MapFrom(

                    dto => new Address()
                    {
                        City = dto.City,
                        Street = dto.Street,
                        HouseNumber = dto.HouseNumber,
                        Country = dto.Country,
                        PostalCode = dto.PostalCode
                    }));

                    //dto => new University           // tutaj jest problem, bo nie chce tworzyć nowej szkoły tylko dodać do jakieś istniejącej w bazie danych
                    //{                               // tak samo będzie dla subjectu 
                    //    Name = dto.Name             // 
                    //});
        }
    }
}
