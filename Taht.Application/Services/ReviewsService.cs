using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application
{
    public class ReviewsService : BaseService<Review, ReviewDto, ReviewUpsertDto, BaseSearchObject, IReviewsRepository>, IReviewsService
    {
        public ReviewsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReviewUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
