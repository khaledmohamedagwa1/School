namespace School.Data.Data;
public class Student
{
    [Key]
    public int StudID { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    [StringLength(500)]
    public string Address { get; set; }
    [StringLength(11)]
    public string Phone { get; set; }
    [StringLength(maximumLength:11,MinimumLength =11)]
    public int? DID { get; set; }
    [ForeignKey(nameof(DID))]
    public virtual Department Depatment { get; set; }
}
