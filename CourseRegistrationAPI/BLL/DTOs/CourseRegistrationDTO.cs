namespace BLL.DTOs;

public class CourseRegistrationDTO
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public string Status { get; set; } // Pending, Confirmed, Cancelled
}