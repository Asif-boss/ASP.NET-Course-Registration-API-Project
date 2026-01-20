using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [Column(TypeName = "VARCHAR")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(50)]
    [Column(TypeName = "VARCHAR")]
    public string Email { get; set; }

    // One User → One Student
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; } 
    public virtual User User { get; set; }
    
    // One Student → Many CourseRegistrations
    public virtual List<CourseRegistration> CourseRegistrations { get; set; }

    public Student()
    {
        CourseRegistrations = new List<CourseRegistration>();
    }
}