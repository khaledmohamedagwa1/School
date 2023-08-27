
using School.Data.Data;
using School.Infrastructure.Abstracts;
using School.Service.Abstracts;

namespace School.Service.Implementation;

public class StudentService : IStudentService
{
    #region Fields
    private readonly IStudentRepository _studentRepository;
    #endregion
    #region Constructor
    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    #endregion
    #region Methods
    public async Task<List<Student>> GetStudensListAsync()
    {
        return await _studentRepository.GetStudentsListAsync();
    } 
    #endregion
}
