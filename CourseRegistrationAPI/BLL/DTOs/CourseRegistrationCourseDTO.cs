namespace BLL.DTOs;

public class CourseRegistrationCourseDTO : CourseDTO
{
    public List<CourseRegistrationDTO> CourseRegistrations { get; set; }

    public CourseRegistrationCourseDTO()
    {
        CourseRegistrations = new List<CourseRegistrationDTO>();
    }
}