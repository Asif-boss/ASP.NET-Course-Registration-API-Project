using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services;

public class CourseRegistrationService
{
    DataAccessFactory factory;
    public CourseRegistrationService(DataAccessFactory factory) { 
        this.factory = factory;
    }
    
    // CRUD
    public CourseRegistrationDTO Get(int id)
    {
        return MapperConfig.GetMapper().Map<CourseRegistrationDTO>(factory.CourseRegistrationData().Get(id));
    }

    public List<CourseRegistrationDTO> Get()
    {
        var data = factory.CourseRegistrationData().Get();
        var mapper = MapperConfig.GetMapper();
        var ret = mapper.Map<List<CourseRegistrationDTO>>(data);
        return ret;
    }

    public bool Create(CourseRegistrationDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<CourseRegistration>(entity);
        return factory.CourseRegistrationData().Create(data);
    }

    public bool Update(CourseRegistrationDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<CourseRegistration>(entity);
        return factory.CourseRegistrationData().Update(data);
    }

    public bool Delete(int id)
    {
        return factory.CourseRegistrationData().Delete(id);
    }
    
    
    // Unique
}