using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SingnalRApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>();
            CreateMap<About, CreateAboutDto>();
            CreateMap<About, GetAboutDto>();
            CreateMap<About, UpdateAboutDto>();
        }
    }
}
