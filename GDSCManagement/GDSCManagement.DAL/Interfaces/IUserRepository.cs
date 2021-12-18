using GDSCManagement.Domain.Models;

namespace GDSCManagement.DAL.Interfaces;

public interface IUserRepository : IRepository<User>
{
    public bool CheckEmail(string email);

}