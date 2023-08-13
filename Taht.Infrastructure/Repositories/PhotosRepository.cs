using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class PhotosRepository : BaseRepository<Photo, int, BaseSearchObject>, IPhotosRepository
    {
        public PhotosRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
