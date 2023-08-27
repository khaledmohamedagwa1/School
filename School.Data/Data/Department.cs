namespace School.Data.Data;
public class Department
{
    public Department()
    {
        Students= new HashSet<Student>();
        DepartmentSubjects =new HashSet<DepartmentSubject>();
    }
    [Key]
    public int DID { get; set; }
    [StringLength(500)]
    public string Name { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }  
    
}