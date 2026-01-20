using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class Course
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Title { get; set; }

    [Required]
    public int Credits { get; set; }
    
    public int Capacity { get; set; } = 40;
    public int EnrolledCount { get; set; } = 0;

    [Required]
    public bool IsOpen { get; set; } = true;
    
    [Required]
    [ForeignKey("Instructor")]
    public int InstructorId { get; set; }
    public virtual Instructor Instructor { get; set; }

    // One Course → Many Registration
    public virtual List<CourseRegistration> CourseRegistrations { get; set; }

    public Course()
    {
        CourseRegistrations = new List<CourseRegistration>();
    }
}