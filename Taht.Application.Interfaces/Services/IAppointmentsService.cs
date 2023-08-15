using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IAppointmentsService : IBaseService<int, AppointmentDto, AppointmentUpsertDto, BaseSearchObject>
    {
    }
}

