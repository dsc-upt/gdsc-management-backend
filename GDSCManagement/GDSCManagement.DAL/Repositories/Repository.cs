using GDSCManagement.DAL.Interfaces;

namespace GDSCManagement.DAL.Repositories;

public class Repository<T> : IRepository<T>
{
    public Task<T> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAsync()
    {
        throw new NotImplementedException();
    }
}