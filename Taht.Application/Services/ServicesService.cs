using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application
{
    public class ServicesService : BaseService<Service, ServiceDto, ServiceUpsertDto, BaseSearchObject, IServicesRepository>, IServicesService
    {
        public ServicesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ServiceUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
