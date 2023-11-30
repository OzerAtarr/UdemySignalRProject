using AutoMapper;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SocialMediaMapper : Profile
	{
		public SocialMediaMapper()
		{
			CreateMap<SocialMedia, ResultSocialMediaDto>();
			CreateMap<SocialMedia, CreateSocialMediaDto>();
			CreateMap<SocialMedia, UpdateSocialMediaDto>();
			CreateMap<SocialMedia, GetSocialMediaDto>();

		}
	}
}
