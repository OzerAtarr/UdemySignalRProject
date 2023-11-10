using AutoMapper;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SingnalRApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>();
            CreateMap<Feature, CreateFeatureDto>();
            CreateMap<Feature, UpdateFeatureDto>();
            CreateMap<Feature, GetFeatureDto>();

        }
    }
}
