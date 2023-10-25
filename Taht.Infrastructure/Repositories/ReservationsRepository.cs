using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class ReservationsRepository : BaseRepository<Reservation, int, BaseSearchObject>, IReservationsRepository
    {
        private readonly ILogger<Reservation> _logger;
        public ReservationsRepository(DatabaseContext databaseContext, ILogger<Reservation> logger) : base(databaseContext)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<string>> GetAvailableAppointmentTimesForServiceAndDate(int serviceId, DateTime date, CancellationToken cancellationToken = default)
        {
            var appointments = await DbSet.AsNoTracking()
                .Where(r => r.ReservationDate == date
                && r.ServiceId == serviceId)
                .Select(r => r.AppointmentTime)
                .ToListAsync();

            return appointments;
        }

        public override async Task<Reservation?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking()
                             .Include(r => r.User)
                             .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByUser(int userId, CancellationToken cancellationToken = default)
        {
            return await DbSet.AsNoTracking()
                .Where(r => r.UserId == userId)
                .ToListAsync();
        }
    }
}
