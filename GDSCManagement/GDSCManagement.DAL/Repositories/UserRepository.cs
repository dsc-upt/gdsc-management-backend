using GDSCManagement.DAL.Database;
using GDSCManagement.DAL.Interfaces;
using GDSCManagement.Domain.Models;

namespace GDSCManagement.DAL.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{

    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }
    
    public bool CheckEmail(string email)
    {
        if (email.Trim().EndsWith("."))
        {
            return false; // suggested by @TK-421
        }

        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    
}