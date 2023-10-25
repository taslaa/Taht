using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Taht.Core;

namespace Taht.Application
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>().ReverseMap();
            CreateMap<ReviewUpsertDto, Review>();

            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User));

            CreateMap<IQueryable<Review>, PagedList<ReviewDto>>()
                .ReverseMap();
        }
    }
}
