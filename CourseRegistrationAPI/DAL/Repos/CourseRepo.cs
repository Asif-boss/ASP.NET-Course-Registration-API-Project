using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;

namespace DAL.Repos;

internal class CourseRepo : IRepository<Course>
{
    CRSContext db;
    public CourseRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public Course Get(int id)
    {
        return db.Courses.Find(id);
    }

    public List<Course> Get()
    {
        return db.Courses.ToList();
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
}