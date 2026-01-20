using DAL.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF;

public class CRSContext : DbContext
{
    public CRSContext(DbContextOptions<CRSContext> opt):base(opt) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseRegistration> CourseRegistrations { get; set; }
    public DbSet<Notification> Notifications { get; set; }
}