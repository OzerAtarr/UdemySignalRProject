using AutoMapper;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ProductMapping : Profile
	{
		public ProductMapping()
		{
			CreateMap<Product, ResultProductDto>();
			CreateMap<Product, ResultProductWithCategory>();
			CreateMap<Product, CreateProductDto>();
			CreateMap<Product, UpdateProductDto>();
			CreateMap<Product, GetProductDto>();
		}
	}
}
