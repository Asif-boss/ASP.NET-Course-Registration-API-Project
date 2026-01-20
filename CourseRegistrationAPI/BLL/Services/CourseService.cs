using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services;

public class CourseService
{
    DataAccessFactory factory;
    public CourseService(DataAccessFactory factory) { 
        this.factory = factory;
    }
    
    // CRUD
    public CourseDTO Get(int id)
    {
        return MapperConfig.GetMapper().Map<CourseDTO>(factory.CourseData().Get(id));
    }

    public List<CourseDTO> Get()
    {
        var data = factory.CourseData().Get();
        var mapper = MapperConfig.GetMapper();
        var ret = mapper.Map<List<CourseDTO>>(data);
        return ret;
    }

    public bool Create(CourseDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Course>(entity);
        return factory.CourseData().Create(data);
    }

    public bool Update(CourseDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Course>(entity);
        return factory.CourseData().Update(data);
    }

    public bool Delete(int id)
    {
        return factory.CourseData().Delete(id);
    }
    
    
    // Unique
    public List<CourseDTO> SearchWithTitle(string title)
    {
        return MapperConfig.GetMapper().Map<List<CourseDTO>>(factory.CourseFeature().SearchWithTitle(title));
    }
    
    public List<CourseDTO> SearchWithInstructorId(int instructorId)
    {
        return MapperConfig.GetMapper().Map<List<CourseDTO>>(factory.CourseFeature().SearchWithInstructorId(instructorId));
    }

    public bool IsSeatAvailable(int id)
    {
        return factory.CourseFeature().IsSeatAvailable(id);
    }

    public bool CloseCourse(int id)
    {
        return factory.CourseFeature().CloseCourse(id);
    }
}