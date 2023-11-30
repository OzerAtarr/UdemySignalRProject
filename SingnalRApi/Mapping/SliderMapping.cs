using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class SliderMapping : Profile
	{
		public SliderMapping()
		{
			CreateMap<Slider, ResultSliderDto>();
			CreateMap<Slider, CreateSliderDto>();
			CreateMap<Slider, UpdateSliderDto>();
			CreateMap<Slider, GetSliderDto>();

		}
	}
}
