using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IReservationsService : IBaseService<int, ReservationDto, ReservationUpsertDto, BaseSearchObject>
    {
        Task CancelReservationAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<string>> GetAvailableAppointmentTimesForServiceAndDate(int serviceId, DateTime date, CancellationToken cancellationToken = default);
        Task<IEnumerable<Reservation>> GetReservationsByUser(int userId, CancellationToken cancellationToken = default);
        Task AcceptReservation(int reservationId, CancellationToken cancellationToken = default);
    }
}
