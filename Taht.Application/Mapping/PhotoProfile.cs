using Microsoft.AspNetCore.Http;
using Taht.Core;

namespace Taht.Application
{
    public class PhotoProfile : BaseProfile
    {
        public PhotoProfile()
        {
            CreateMap<PhotoDto, Photo>().ReverseMap();

            CreateMap<PhotoUpsertDto, Photo>();

            CreateMap<IFormFile, Photo>().ReverseMap();

            CreateMap<IFormFile, PhotoUpsertDto>().ReverseMap();

        }
    }
}
