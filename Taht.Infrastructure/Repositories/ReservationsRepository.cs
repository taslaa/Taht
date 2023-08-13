using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class ReservationsRepository : BaseRepository<Reservation, int, BaseSearchObject>, IReservationsRepository
    {
        public ReservationsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
