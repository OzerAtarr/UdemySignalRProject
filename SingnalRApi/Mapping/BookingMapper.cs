using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class BookingMapper : Profile
	{
		public BookingMapper()
		{
			CreateMap<Booking, ResultBookingDto>();
			CreateMap<Booking, CreateBookingDto>();
			CreateMap<Booking, UpdateBookingDto>();
			CreateMap<Booking, GetBookingDto>();
		}
	}
}
