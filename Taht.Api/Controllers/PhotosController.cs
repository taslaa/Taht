using Microsoft.AspNetCore.Mvc;

using Taht.Core;
using Taht.Application.Interfaces;
using Taht.Infrastructure.Interfaces;

namespace Taht.Api.Controllers
{
    public class PhotosController : BaseCrudController<PhotoDto, PhotoUpsertDto, BaseSearchObject, IPhotosService>
    {
        public PhotosController(IPhotosService service, ILogger<PhotosController> logger) : base(service, logger)
        {
        }

        public override async Task<IActionResult> Get(int id, CancellationToken cancellationToken = default)
        {
            var photo = await Service.GetByIdAsync(id, cancellationToken);
            if (photo == null)
                return NotFound();

            return File(photo.Data, photo.ContentType, $"photo-{id}", true);
        }
    }
}