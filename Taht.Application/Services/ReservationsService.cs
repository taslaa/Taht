using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application
{
    public class ReservationsService : BaseService<Reservation, ReservationDto, ReservationUpsertDto, BaseSearchObject, IReservationsRepository>, IReservationsService
    {
        public ReservationsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReservationUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }

        public async Task CancelReservationAsync(int id, CancellationToken cancellationToken = default)
        {
            var reservation = await CurrentRepository.GetByIdAsync(id, cancellationToken);
            if (reservation == null)
                throw new UserNotFoundException();

            reservation.Status = ReservationStatus.Canceled;

            await UnitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
