using AutoMapper;
using NewStudiesAPI.Entities;
using NewStudiesAPI.Models;

namespace NewStudentAPI
{
    public class LecturerMappingProfile : Profile
    {
        public LecturerMappingProfile()
        {
            CreateMap<Lecturer, LecturerDto>()
                .ForMember(m => m.City, c => c.MapFrom(a => a.LecturerAddress.City))
            .ForMember(m => m.Street, c => c.MapFrom(a => a.LecturerAddress.Street))
            .ForMember(m => m.HouseNumber, c => c.MapFrom(a => a.LecturerAddress.HouseNumber))
            .ForMember(m => m.Country, c => c.MapFrom(a => a.LecturerAddress.Country))
            .ForMember(m => m.PostalCode, c => c.MapFrom(a => a.LecturerAddress.PostalCode))
            .ForMember(m => m.UniversityName, c => c.MapFrom(u => u.LecturerUniversity.Name))
            .ForMember(m => m.Subjects, c => c.MapFrom(l => l.Subjects));

        }
    }
}

