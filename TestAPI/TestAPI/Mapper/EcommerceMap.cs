using AutoMapper;
using TestAPI.DataModel;
using TestAPI.Models;

namespace TestAPI.Mapper
{
    public class EcommerceMap : Profile
    {
        public EcommerceMap()
        {
            CreateMap<Category, UpsertCategory>().ReverseMap();
        }
    }
}
