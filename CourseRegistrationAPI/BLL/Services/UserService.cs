using BLL.DTOs;
using DAL;
using DAL.EF.Models;

namespace BLL.Services;

public class UserService
{
    DataAccessFactory factory;
    public UserService(DataAccessFactory factory) { 
        this.factory = factory;
    }
    
    // CRUD
    public UserDTO Get(int id)
    {
        //var data = factory.UserData().Get(id);
        // var mapper = MapperConfig.GetMapper();
        // var ret = mapper.Map<List<UserDTO>>(data);
        // return ret;
        
        return MapperConfig.GetMapper().Map<UserDTO>(factory.UserData().Get(id));
    }

    public List<UserDTO> Get()
    {
        var data = factory.UserData().Get();
        var mapper = MapperConfig.GetMapper();
        var ret = mapper.Map<List<UserDTO>>(data);
        return ret;
    }

    public bool Create(UserDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<User>(entity);
        return factory.UserData().Create(data);
    }

    public bool Update(UserDTO entity)
    {
        var mapper = MapperConfig.GetMapper();
        var data = mapper.Map<User>(entity);
        return factory.UserData().Update(data);
    }

    public bool Delete(int id)
    {
        return factory.UserData().Delete(id);
    }
    
    
    // Unique
}