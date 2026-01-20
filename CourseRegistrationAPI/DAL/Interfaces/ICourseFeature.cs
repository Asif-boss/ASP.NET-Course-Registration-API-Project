using DAL.EF.Models;

namespace DAL.Interfaces;

public interface ICourseFeature
{
    List<Course> SearchWithTitle(string title);
    List<Course> SearchWithInstructorId(int instructorId);
    bool IsSeatAvailable(int id);
    bool CloseCourse(int id);
}