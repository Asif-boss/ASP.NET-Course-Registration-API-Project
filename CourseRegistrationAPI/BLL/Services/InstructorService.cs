using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services;

public class InstructorService
{
    DataAccessFactory factory;
    public InstructorService(DataAccessFactory factory) { 
        this.factory = factory;
    }
    
    // CRUD
    public InstructorDTO Get(int id)
    {
        return MapperConfig.GetMapper().Map<InstructorDTO>(factory.InstructorData().Get(id));
    }

    public List<InstructorDTO> Get()
    {
        var data = factory.InstructorData().Get();
        var mapper = MapperConfig.GetMapper();
        var ret = mapper.Map<List<InstructorDTO>>(data);
        return ret;
    }

    public bool Create(InstructorDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Instructor>(entity);
        return factory.InstructorData().Create(data);
    }

    public bool Update(InstructorDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Instructor>(entity);
        return factory.InstructorData().Update(data);
    }

    public bool Delete(int id)
    {
        return factory.InstructorData().Delete(id);
    }
    
    
    // Unique
}