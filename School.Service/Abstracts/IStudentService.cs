
using School.Data.Data;

namespace School.Service.Abstracts;

public interface IStudentService
{
    Task<List<Student>> GetStudensListAsync();
}
