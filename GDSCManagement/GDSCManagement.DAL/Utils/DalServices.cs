using AutoMapper;
using GDSCManagement.DAL.Interfaces;
using GDSCManagement.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GDSCManagement.DAL.Utils;

public static class DalServices
{
    public static void AddRepositories(this IServiceCollection services)
    {

        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        IMapper mapper = mapperConfig.CreateMapper();

        services.AddSingleton(mapper);
        services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IUserRepository, UserRepository>();

    }
}