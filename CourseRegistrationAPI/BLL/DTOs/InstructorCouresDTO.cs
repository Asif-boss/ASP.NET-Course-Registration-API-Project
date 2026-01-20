namespace BLL.DTOs;

public class InstructorCouresDTO : InstructorDTO
{
    public virtual List<CourseDTO> Courses { get; set; }

    public InstructorCouresDTO()
    {
        Courses = new List<CourseDTO>();
    }
}