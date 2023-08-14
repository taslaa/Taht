using Microsoft.AspNetCore.Http;
using Taht.Core;

namespace Taht.Application
{
    public class ReviewProfile : BaseProfile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>().ReverseMap();

            CreateMap<ReviewUpsertDto, Review>();
        }
    }
}
