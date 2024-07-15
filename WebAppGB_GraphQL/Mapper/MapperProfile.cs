using AutoMapper;
using WebAppGB_GraphQL.Dto;
using WebAppGB_GraphQL.Models;

namespace WebAppGB_GraphQL.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductGroup, ProductGroupDto>().ReverseMap();
        }
    }
}
