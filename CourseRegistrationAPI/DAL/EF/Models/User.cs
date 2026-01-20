using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(50)]
    [Column(TypeName = "VARCHAR")]
    public string Email { get; set; }

    [Required]
    [MaxLength(20)]
    [Column(TypeName = "VARCHAR")]
    public string Password { get; set; }

    [Required]
    [MaxLength(20)]
    [Column(TypeName = "VARCHAR")]
    public string Role { get; set; } // Student, Instructor
}