using AutoMapper;
using backend_netcore.Entities;
using backend_netcore.Models.Users;

namespace backend_netcore.Helpers
{
    /*
    The automapper profile contains the mapping configuration used by the application.
    AutoMapper is a package available on Nuget that enables automatic mapping of one type 
    of class to another. II'm using it to map between User entities and a few 
    different model types - UserModel, RegisterModel and UpdateModel.
    */
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}