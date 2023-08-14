using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Taht.Api.Controllers
{
    public class ReservationsController : BaseCrudController<ReservationDto, ReservationUpsertDto, BaseSearchObject, IReservationsService>
    {
        public ReservationsController(IReservationsService service, ILogger<ReservationsController> logger) : base(service, logger)
        {
        }

        [HttpPut("CancelReservation")]
        public async Task<IActionResult> ToggleStatus(int id, CancellationToken cancellationToken = default)
        {
            await Service.CancelReservationAsync(id, cancellationToken);

            return NoContent();
        }
    }
}