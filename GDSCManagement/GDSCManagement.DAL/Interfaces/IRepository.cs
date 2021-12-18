using GDSCManagement.Domain.Abstractions;

namespace GDSCManagement.DAL.Interfaces;

public interface IRepository<T> where T : Entity
{
    Task<List<T>> GetAsync();
    Task<T> GetAsync(string id);
    Task<T> AddAsync(T item);
    Task DeleteAsync(T item);
}