using AutoMapper;
using NewStudiesAPI.Entities;
using NewStudiesAPI.Models;

namespace NewStudentAPI
{
    public class SubjectMappingProfile : Profile
    {
        public SubjectMappingProfile()
        {
            CreateMap<Subject, SubjectDto>();
        }
    }
}
