using AutoMapper;
using FluentValidation;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application
{
    public class PhotosService : BaseService<Photo, PhotoDto, PhotoUpsertDto, BaseSearchObject, IPhotosRepository>, IPhotosService
    {
        public PhotosService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<PhotoUpsertDto> validator) : base(mapper, unitOfWork, validator)
        {
        }
    }
}
