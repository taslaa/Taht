using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class ReviewsRepository : BaseRepository<Review, int, BaseSearchObject>, IReviewsRepository
    {
        public ReviewsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
