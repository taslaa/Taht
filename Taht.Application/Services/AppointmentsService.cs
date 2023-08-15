using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application
{
    public class AppointmentsService : BaseService<Appointment, AppointmentDto, AppointmentUpsertDto, BaseSearchObject, IAppointmentsRepository>, IAppointmentsService
    {
        public AppointmentsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<AppointmentUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
