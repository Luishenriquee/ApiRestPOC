using AR.Presentetion.Domain.Models;
using AR.Presentetion.Resources;
using AutoMapper;

namespace AR.Presentetion.Mapping
{
    public class ResourceToModelProfile : Profile
    {

        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<AuthUserResource, User>();

        }

    }
}
