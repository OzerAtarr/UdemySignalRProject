using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
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
