using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IPhotosService : IBaseService<int, PhotoDto, PhotoUpsertDto, BaseSearchObject>
    {
    }
}
