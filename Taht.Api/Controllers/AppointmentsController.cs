using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;

namespace Taht.Api.Controllers
{
    public class AppointmentsController : BaseCrudController<AppointmentDto, AppointmentUpsertDto, BaseSearchObject, IAppointmentsService>
    {
        public AppointmentsController(IAppointmentsService service, ILogger<AppointmentsController> logger) : base(service, logger)
        {
        }
    }
}