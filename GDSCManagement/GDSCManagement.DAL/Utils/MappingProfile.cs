using AutoMapper;
using GDSCManagement.Domain.DTOS;
using GDSCManagement.Domain.Models;

namespace GDSCManagement.DAL.Utils;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserRequest>();
        CreateMap<UserRequest, User>();
    }
}