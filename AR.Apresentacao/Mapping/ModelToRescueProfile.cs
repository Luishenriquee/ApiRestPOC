using AR.Presentetion.Domain.Models;
using AR.Presentetion.Extensions;
using AR.Presentetion.Resources;
using AutoMapper;


namespace AR.Presentetion.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<User, UserResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));


        }
    }
}
