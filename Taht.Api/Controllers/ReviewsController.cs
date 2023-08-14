using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;

namespace Taht.Api.Controllers
{
    public class ReviewsController : BaseCrudController<ReviewDto, ReviewUpsertDto, BaseSearchObject, IReviewsService>
    {
        public ReviewsController(IReviewsService service, ILogger<ReviewsController> logger) : base(service, logger)
        {
        }
    }
}