using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services;

public class StudentService
{
    DataAccessFactory factory;
    public StudentService(DataAccessFactory factory) { 
        this.factory = factory;
    }
    
    // CRUD
    public StudentDTO Get(int id)
    {
        return MapperConfig.GetMapper().Map<StudentDTO>(factory.StudentData().Get(id));
    }

    public List<StudentDTO> Get()
    {
        var data = factory.StudentData().Get();
        var mapper = MapperConfig.GetMapper();
        var ret = mapper.Map<List<StudentDTO>>(data);
        return ret;
    }

    public bool Create(StudentDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Student>(entity);
        return factory.StudentData().Create(data);
    }

    public bool Update(StudentDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<Student>(entity);
        return factory.StudentData().Update(data);
    }

    public bool Delete(int id)
    {
        return factory.StudentData().Delete(id);
    }
    
    
    // Unique
}