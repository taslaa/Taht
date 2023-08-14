using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IReservationsService : IBaseService<int, ReservationDto, ReservationUpsertDto, BaseSearchObject>
    {
        Task CancelReservationAsync(int id, CancellationToken cancellationToken = default);
    }
}
