
namespace School.Infrastructure.Abstracts;
public  interface IStudentRepository
{
    Task<List<Student>> GetStudentsListAsync();
}
