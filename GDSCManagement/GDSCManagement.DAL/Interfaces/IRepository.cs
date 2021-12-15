namespace GDSCManagement.DAL.Interfaces;

public interface IRepository<T>
{
    Task<T> GetAsync(string id);
    Task<List<T>> GetAsync();
}