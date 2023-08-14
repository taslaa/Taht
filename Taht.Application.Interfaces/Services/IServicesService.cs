using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IServicesService : IBaseService<int, ServiceDto, ServiceUpsertDto, BaseSearchObject>
    {
    }
}
