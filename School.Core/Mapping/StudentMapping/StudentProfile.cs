

using AutoMapper;
using School.Core.Features.Query.Resoponse;
namespace School.Core.Mapping.StudentMapping;

public partial class StudentProfile : Profile
{
    public StudentProfile()
    {
        GetStudentListMapping();
          
    }
}
