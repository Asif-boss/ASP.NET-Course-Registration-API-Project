using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class Instructor
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
    
    [Required]
    [MaxLength(50)]
    public string Department { get; set; }
    
    // One User → One Instructor
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; } 
    public virtual User User { get; set; }
    
    // One Instructor → Many Courses
    public virtual List<Course> Courses { get; set; }

    public Instructor()
    {
        Courses = new List<Course>();
    }
}