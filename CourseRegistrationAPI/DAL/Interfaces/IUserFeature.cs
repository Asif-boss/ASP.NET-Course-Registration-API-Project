using DAL.EF.Models;

namespace DAL.Interfaces;

public interface IUserFeature
{
    User Login(int id , string password);
}