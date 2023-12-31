﻿using AutoMapper;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class DiscountMapping : Profile
	{
		public DiscountMapping()
		{
			CreateMap<Discount, ResultDiscountDto>();
			CreateMap<Discount, CreateDiscountDto>();
			CreateMap<Discount, UpdateDiscountDto>();
			CreateMap<Discount, GetDiscountDto>();
		}
	}
}
