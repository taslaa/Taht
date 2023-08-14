using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;

namespace Taht.Api.Controllers
{
    public class ServicesController : BaseCrudController<ServiceDto, ServiceUpsertDto, BaseSearchObject, IServicesService>
    {
        public ServicesController(IServicesService service, ILogger<ServicesController> logger) : base(service, logger)
        {
        }
    }
}