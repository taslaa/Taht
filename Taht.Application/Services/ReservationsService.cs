using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Taht.Application
{
    public class ReservationsService : BaseService<Reservation, ReservationDto, ReservationUpsertDto, BaseSearchObject, IReservationsRepository>, IReservationsService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IEmailService _emailService;
        public ReservationsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ReservationUpsertDto> validator, DatabaseContext dbContext, IEmailService emailService) : base(mapper, unitOfWork, validator)
        {
            _dbContext = dbContext;
            _emailService = emailService;
        }

        public async Task AcceptReservation(int reservationId, CancellationToken cancellationToken = default)
        {
            var reservation = await CurrentRepository.GetByIdAsync(reservationId, cancellationToken);

            if (reservation == null)
                throw new UserNotFoundException();

            if (reservation.Status != ReservationStatus.Canceled)
            {
                reservation.Status = ReservationStatus.Canceled;

                try
                {
                    await UnitOfWork.SaveChangesAsync(cancellationToken);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    throw ex;
                }
            }

            string userName = reservation.User.FirstName + " " + reservation.User.LastName;
            string reservationDate = reservation.ReservationDate.ToString("dddd, MMMM d, yyyy");
            string reservationTime = reservation.AppointmentTime ?? "No Time Provided"; 

            string confirmationMessage = $"Dear {userName},\n\n"
                + $"Your reservation has been confirmed. We're looking forward seeing you on {reservationDate} at {reservationTime}.\n"
                + "\n"
                + "If you have any questions or need to make changes to your reservation, please don't hesitate to contact us.\n\n"
                + "Best regards,\n"
                + "Taht Sarajevo";

            var message = new Message(new string[] { "hamza.taslidza01@gmail.com" }, "Reservation confirmation", confirmationMessage);
            _emailService.SendEmail(message);
        }

        public async Task CancelReservationAsync(int id, CancellationToken cancellationToken = default)
        {
            var reservation = await CurrentRepository.GetByIdAsync(id, cancellationToken);
            if (reservation == null)
                throw new UserNotFoundException();

            reservation.Status = ReservationStatus.Canceled;

            await UnitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IEnumerable<string>> GetAvailableAppointmentTimesForServiceAndDate(int serviceId, DateTime date, CancellationToken cancellationToken = default)
        {
            var availableAppointmentTimes = await CurrentRepository.GetAvailableAppointmentTimesForServiceAndDate(serviceId, date, cancellationToken);

            return availableAppointmentTimes;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByUser(int userId, CancellationToken cancellationToken = default)
        {
            var reservations = await CurrentRepository.GetReservationsByUser(userId, cancellationToken);

            return reservations;
        }
    }
}
