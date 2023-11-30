using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class TestimonialMapping : Profile
	{
		public TestimonialMapping()
		{
			CreateMap<Testimonial, ResultTestimonialDto>();
			CreateMap<Testimonial, UpdateTestimonialDto>();
			CreateMap<Testimonial, CreateTestimonialDto>();
			CreateMap<Testimonial, GetTestimonialDto>();

		}
	}
}
