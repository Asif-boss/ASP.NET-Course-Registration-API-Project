using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;

namespace DAL.Repos;

internal class CourseRegistrationRepo : IRepository<CourseRegistration>, ICourseRegistrationFeature
{
    CRSContext db;
    public CourseRegistrationRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public CourseRegistration Get(int id)
    {
        return db.CourseRegistrations.Find(id);
    }

    public List<CourseRegistration> Get()
    {
        return db.CourseRegistrations.ToList();
    }

    public bool Create(CourseRegistration entity)
    {
        db.CourseRegistrations.Add(entity);
        return db.SaveChanges()>0;
    }

    public bool Update(CourseRegistration entity)
    {
        var ex =Get(entity.Id);
        db.Entry(ex).CurrentValues.SetValues(entity);
        return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var ex = Get(id);
        db.CourseRegistrations.Remove(ex);
        return db.SaveChanges() > 0;
    }
    
    
    // Unique
    public bool CancelRegistration(int studentId, int courseId)
    {
        var ex = db.CourseRegistrations.SingleOrDefault(c => c.StudentId == studentId && c.CourseId == courseId);
        db.CourseRegistrations.Remove(ex);
        return db.SaveChanges() > 0;
    }

    public List<CourseRegistration> GetStudentRegistrations(int studentId)
    {
        return db.CourseRegistrations.Where(c => c.StudentId == studentId).ToList();
    }

    public List<CourseRegistration> GetStudentsList(int courseId)
    {
        return db.CourseRegistrations.Where(c => c.CourseId == courseId).ToList();
    }
}