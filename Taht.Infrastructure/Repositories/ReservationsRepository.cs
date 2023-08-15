using Microsoft.EntityFrameworkCore;
using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class ReservationsRepository : BaseRepository<Reservation, int, BaseSearchObject>, IReservationsRepository
    {
        public ReservationsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }

        public override async Task<Reservation?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking()
                             .Include(r => r.Appointment)
                             .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
        }
    }
}
