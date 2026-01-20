using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;

namespace DAL.Repos;

internal class UserRepo : IRepository<User>, IUserFeature
{
    CRSContext db;
    public UserRepo(CRSContext db)
    {
        this.db = db;
    }
    
    // CRUD
    public User Get(int id)
    {
        return db.Users.Find(id);
    }

    public List<User> Get()
    {
        return db.Users.ToList();
    }

    public bool Create(User entity)
    {
        db.Users.Add(entity);
        return db.SaveChanges()>0;
    }

    public bool Update(User entity)
    {
        var ex =Get(entity.Id);
        db.Entry(ex).CurrentValues.SetValues(entity);
        return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        var ex = Get(id);
        db.Users.Remove(ex);
        return db.SaveChanges() > 0;
    }
    
    
    // Unique
    public User Login(int id, string password)
    {
        var user = db.Users.SingleOrDefault(u => u.Id == id && u.Password == password);
        return user;
    }
}