using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class ServicesRepository : BaseRepository<Service, int, BaseSearchObject>, IServicesRepository
    {
        public ServicesRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
