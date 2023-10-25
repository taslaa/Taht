using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Taht.Application
{
    public class ReviewsService : BaseService<Review, ReviewDto, ReviewUpsertDto, BaseSearchObject, IReviewsRepository>, IReviewsService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;

        public ReviewsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReviewUpsertDto> validator, DatabaseContext dbContext) : base(mapper, unitOfWork, validator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<PagedList<ReviewDto>> GetPagedAsync(BaseSearchObject searchObject, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.Reviews
                .Include(r => r.User) // Include the User navigation property
                .AsNoTracking();

            var totalCount = await query.CountAsync();

            var reviews = await query
                .Skip((searchObject.PageNumber - 1) * searchObject.PageSize)
                .Take(searchObject.PageSize)
                .ToListAsync(cancellationToken);

            var reviewDtos = _mapper.Map<List<ReviewDto>>(reviews);

            var pagedList = new PagedList<ReviewDto>
            {
                PageNumber = searchObject.PageNumber,
                PageSize = searchObject.PageSize,
                TotalCount = totalCount,
                Items = reviewDtos,
                PageCount = (int)Math.Ceiling((double)totalCount / searchObject.PageSize),
                HasPreviousPage = searchObject.PageNumber > 1,
                HasNextPage = searchObject.PageNumber < (int)Math.Ceiling((double)totalCount / searchObject.PageSize),
                IsFirstPage = searchObject.PageNumber == 1,
                IsLastPage = searchObject.PageNumber == (int)Math.Ceiling((double)totalCount / searchObject.PageSize)
            };

            return pagedList;
        }


    }
}
