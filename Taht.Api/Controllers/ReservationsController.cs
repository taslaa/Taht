using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Taht.Api.Controllers
{
    public class ReservationsController : BaseCrudController<ReservationDto, ReservationUpsertDto, BaseSearchObject, IReservationsService>
    {
        private readonly IEmailService _emailService;
        public ReservationsController(IReservationsService service, ILogger<ReservationsController> logger, IEmailService emailService) : base(service, logger)
        {
            _emailService = emailService;
        }

        [HttpPut("CancelReservation")]
        public async Task<IActionResult> ToggleStatus(int id, CancellationToken cancellationToken = default)
        {
            await Service.CancelReservationAsync(id, cancellationToken);

            return NoContent();
        }

        [HttpGet("GetAvailableAppointments")]
        public async Task<IActionResult> GetAvailableAppointmentTimesForServiceAndDate(int id, DateTime date, CancellationToken cancellationToken = default)
        {
            var appointments = await Service.GetAvailableAppointmentTimesForServiceAndDate(id, date, cancellationToken);

            return Ok(appointments);
        }

        [HttpGet("GetReservationsByUser")]
        public async Task<IActionResult> GetReservationsByUser(int userId, CancellationToken cancellationToken = default)
        {
            var reservations = await Service.GetReservationsByUser(userId, cancellationToken);

            return Ok(reservations);
        }

        [HttpPut("AcceptReservation")]
        public async Task<IActionResult> AcceptReservation(int reservationId, CancellationToken cancellationToken = default)
        {
            await Service.AcceptReservation(reservationId, cancellationToken);

            return NoContent();
        }
    }
}