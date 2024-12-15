using Acme.StudentsManagement.Student.Dtos;
using AutoMapper;
namespace Acme.StudentsManagement.Students;

public class StudentsManagementApplicationAutoMapperProfile : Profile
{
    public StudentsManagementApplicationAutoMapperProfile()
    {
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
