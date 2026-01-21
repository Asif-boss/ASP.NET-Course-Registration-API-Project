using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repos;

internal class CourseRepo : IRepository<Course>, ICourseFeature
{
    CRSContext db;
    public CourseRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public Course Get(int id)
    {
        return db.Courses.Include(c=>c.CourseRegistrations).FirstOrDefault(i => i.Id == id);
    }

    public List<Course> Get()
    {
        return db.Courses.Include(c=>c.CourseRegistrations).ToList();
    }

    public bool Create(Course entity)
    {
        db.Courses.Add(entity);
        return db.SaveChanges()>0;
    }

    public bool Update(Course entity)
    {
        var ex =Get(entity.Id);
        db.Entry(ex).CurrentValues.SetValues(entity);
        return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Courses.Remove(ex);
        return db.SaveChanges() > 0;
    }
    
    
    // Unique
    public List<Course> SearchWithTitle(string title)
    {
        return db.Courses.Where(c => c.Title == title).ToList();
    }

    public List<Course> SearchWithInstructorId(int instructorId)
    {
        return db.Courses.Where(c => c.InstructorId == instructorId).ToList();
    }

    public bool IsSeatAvailable(int id)
    {
        var course = db.Courses.SingleOrDefault(c => c.Id == id);
        if(course.EnrolledCount <= 36 && course!=null) return true;
        return false;
    }

    public bool CloseCourse(int id)
    {
        return db.Courses.SingleOrDefault(c => c.Id == id).IsOpen;
    }
}