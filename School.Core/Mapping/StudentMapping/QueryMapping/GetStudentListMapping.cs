
using AutoMapper;
using School.Core.Features.Query.Resoponse;


namespace School.Core.Mapping.StudentMapping;

public partial class StudentProfile
{
    public void GetStudentListMapping()
    {
        CreateMap<Data.Data.Student, GetStudentListResponse>()
           .ForMember(dest => dest.DepartmentName, op => op.MapFrom(src => src.Depatment.Name));
    }
}
