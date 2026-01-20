using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;

namespace DAL;

public class DataAccessFactory
{
    CRSContext db;
    public DataAccessFactory(CRSContext db)
    {
        this.db = db;
    }
    
    public IRepository<User> UserData() {
        return new UserRepo(db);
    }
    public IRepository<Student> StudentData() {
        return new StudentRepo(db);
    }
    public IRepository<Instructor> InstructorData() {
        return new InstructorRepo(db);
    }
    public IRepository<CourseRegistration> CourseRegistrationData() {
        return new CourseRegistrationRepo(db);
    }
    public IRepository<Course> CourserData() {
        return new CourseRepo(db);
    }
    
    
    // public ICategoryFeature CategoryFeature() {
    //     return new CategoryRepo(db);
    // }
}