using GDSCManagement.DAL.Database;
using GDSCManagement.DAL.Interfaces;
using GDSCManagement.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GDSCManagement.DAL.Repositories;

public class Repository<T> : IRepository<T> where T : Entity
{
    protected readonly ApplicationDbContext DbContext;
    protected readonly DbSet<T> DbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = dbContext.Set<T>();
    }
    public virtual async Task<List<T>> GetAsync()
    {
        var response = await DbSet.ToListAsync();
        return response;
    }

    public virtual async Task<T> GetAsync(string id)
    {
        var response = await DbSet.FirstOrDefaultAsync(p => p.Id == id);
        return response;
    }

    public virtual async Task<T> AddAsync(T item)
    {
        var entry = await DbSet.AddAsync(item);

        await DbContext.SaveChangesAsync();

        return entry.Entity;

    }

    public virtual async Task DeleteAsync(T item)
    {
        DbContext.Set<T>().Remove(item);
        await DbContext.SaveChangesAsync();

    }
    
}