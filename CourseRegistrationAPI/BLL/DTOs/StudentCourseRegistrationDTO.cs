namespace BLL.DTOs;

public class StudentCourseRegistrationDTO : StudentDTO
{
    public virtual List<CourseRegistrationDTO> CourseRegistrations { get; set; }

    public StudentCourseRegistrationDTO()
    {
        CourseRegistrations = new List<CourseRegistrationDTO>();
    }
}