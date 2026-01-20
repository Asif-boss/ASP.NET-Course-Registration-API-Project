using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;

namespace DAL.Repos;

internal class InstructorRepo : IRepository<Instructor>
{
    CRSContext db;
    public InstructorRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public Instructor Get(int id)
    {
        return db.Instructors.Find(id);
    }

    public List<Instructor> Get()
    {
        return db.Instructors.ToList();
    }

    public bool Create(Instructor entity)
    {
        db.Instructors.Add(entity);
        return db.SaveChanges()>0;
    }

    public bool Update(Instructor entity)
    {
        var ex =Get(entity.Id);
        db.Entry(ex).CurrentValues.SetValues(entity);
        return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Instructors.Remove(ex);
        return db.SaveChanges() > 0;
    }
    
    
    // Unique
}