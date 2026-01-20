using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class Notification
{
    public int Id { get; set; }

    [Required]
    [ForeignKey("Student")]
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }

    [Required]
    [MaxLength(100)]
    public string Message { get; set; }

    public bool IsRead { get; set; } = false;
}