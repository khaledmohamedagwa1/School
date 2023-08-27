using Microsoft.EntityFrameworkCore;
using School.Data.Data;

namespace School.Infrastructure.Context;

public class ApplicationContext :DbContext
{
    #region Constructors
    public ApplicationContext() { }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    { }
    #endregion


    #region DBSet Properties
    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Subject> Subjects { get; set; }    
    public virtual DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
    public virtual DbSet<StudentSubject> StudentSubjects { get; set; }  
    #endregion
}
