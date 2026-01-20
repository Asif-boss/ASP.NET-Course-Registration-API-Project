using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class CourseRegistration
{
    public int Id { get; set; }

    [Required]
    [ForeignKey("Student")]
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    
    [Required]
    [ForeignKey("Course")]
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }
    

    [Required]
    [MaxLength(20)]
    public string Status { get; set; } = "Pending"; // Pending, Confirmed, Cancelled
}