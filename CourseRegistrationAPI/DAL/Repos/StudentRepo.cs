using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;

namespace DAL.Repos;

internal class StudentRepo : IRepository<Student>
{
    CRSContext db;
    public StudentRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public Student Get(int id)
    {
        return db.Students.Find(id);
    }

    public List<Student> Get()
    {
        return db.Students.ToList();
    }

    public bool Create(Student entity)
    {
        db.Students.Add(entity);
        return db.SaveChanges()>0;
    }

    public bool Update(Student entity)
    {
        var ex =Get(entity.Id);
        db.Entry(ex).CurrentValues.SetValues(entity);
        return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Students.Remove(ex);
        return db.SaveChanges() > 0;
    }
    
    
    // Unique
}