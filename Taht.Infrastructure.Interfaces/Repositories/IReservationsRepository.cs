﻿using Taht.Core;

namespace Taht.Infrastructure.Interfaces
{
    public interface IReservationsRepository : IBaseRepository<Reservation, int, BaseSearchObject>
    {
        Task<IEnumerable<string>> GetAvailableAppointmentTimesForServiceAndDate(int serviceId, DateTime date, CancellationToken cancellationToken = default);
        Task<IEnumerable<Reservation>> GetReservationsByUser(int userId, CancellationToken cancellationToken = default);
    }
}