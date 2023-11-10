using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SingnalRApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, GetCategoryDto>();
            CreateMap<Category, UpdateCategoryDto>();
        }
    }
}
