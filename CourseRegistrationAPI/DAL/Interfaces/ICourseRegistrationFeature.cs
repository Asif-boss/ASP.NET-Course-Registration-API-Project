using DAL.EF.Models;

namespace DAL.Interfaces;

public interface ICourseRegistrationFeature
{
    bool CancelRegistration(int studentId, int courseId);
    List<CourseRegistration> GetStudentRegistrations(int studentId);
    List<CourseRegistration> GetStudentsList(int courseId);
}