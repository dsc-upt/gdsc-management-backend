using GDSCManagement.DAL.Interfaces;
using GDSCManagement.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GDSCManagement.DAL.Utils;

public static class DalServices
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
    }
}