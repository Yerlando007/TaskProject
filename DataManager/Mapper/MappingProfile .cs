using AutoMapper;
using DataManager.EF;
using DataManager.Response;

namespace DataManager.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Goods, GoodsDto>();
        CreateMap<Categories, CategoryDto>();
        CreateMap<Field, FieldDto>();
        CreateMap<FieldDescribe, FieldDescribeDto>();
    }
}