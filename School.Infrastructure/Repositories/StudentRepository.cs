
using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Context;

namespace School.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    #region Fields
    private readonly ApplicationContext _context;
    #endregion


    #region Constructor
    public StudentRepository(ApplicationContext context)
    {
        _context = context;
    }
    #endregion


    #region Methods
    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _context.Students.Include(a=>a.Depatment).ToListAsync();
    }
    #endregion
}
