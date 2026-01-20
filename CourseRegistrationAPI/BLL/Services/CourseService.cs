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
}