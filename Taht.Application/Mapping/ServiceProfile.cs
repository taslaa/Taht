using Microsoft.AspNetCore.Http;
using Taht.Core;

namespace Taht.Application
{
    public class ServiceProfile : BaseProfile
    {
        public ServiceProfile()
        {
            CreateMap<ServiceDto, Service>().ReverseMap();

            CreateMap<ServiceUpsertDto, Service>();
        }
    }
}
