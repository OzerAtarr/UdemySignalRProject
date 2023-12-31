﻿using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
	public class ContactMapping : Profile
	{
		public ContactMapping()
		{
			CreateMap<Contact, ResultContactDto>();
			CreateMap<Contact, UpdateContactDto>();
			CreateMap<Contact, CreateContactDto>();
			CreateMap<Contact, GetContactDto>();
		}
	}
}
