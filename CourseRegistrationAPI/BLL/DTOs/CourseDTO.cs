namespace BLL.DTOs;

public class CourseDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public int Capacity { get; set; }
    public int EnrolledCount { get; set; }
    public bool IsOpen { get; set; } = true;
    public int InstructorId { get; set; }
}