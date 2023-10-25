using Microsoft.AspNetCore.Mvc;

using Taht.Core;
using Taht.Application.Interfaces;
using AutoMapper;
using Taht.Infrastructure.Interfaces;

namespace Taht.Api.Controllers
{
    public class UsersController : BaseCrudController<UserDto, UserUpsertDto, UserSearchObject, IUsersService>
    {
        private readonly IMapper _mapper;

        public UsersController(IUsersService service, IMapper mapper, ILogger<UsersController> logger) : base(service, logger)
        {
            _mapper = mapper;
        }

        [NonAction]
        public override Task<IActionResult> Post(UserUpsertDto upsertDto, CancellationToken cancellationToken = default) => base.Post(upsertDto, cancellationToken);

        [NonAction]
        public override Task<IActionResult> Put(UserUpsertDto upsertDto, CancellationToken cancellationToken = default) => base.Put(upsertDto, cancellationToken);

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] UserUpsertModel model, CancellationToken cancellationToken = default)
        {
            try
            {
                var upsertDto = _mapper.Map<UserUpsertDto>(model);

                var user = await Service.AddAsync(upsertDto, cancellationToken);

                return Ok(user);
            }
            catch (ValidationException e)
            {
                Logger.LogError(e, "Error while adding user with photo.");
                return ValidationResult(e.Errors);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromForm] UserUpsertModel model, CancellationToken cancellationToken = default)
        {
            try
            {
                var upsertDto = _mapper.Map<UserUpsertDto>(model);

                await Service.UpdateAsync(upsertDto, cancellationToken);

                return Ok(upsertDto);
            }
            catch (ValidationException e)
            {
                Logger.LogError(e, "Error while updating user info.");
                return ValidationResult(e.Errors);
            }
        }
    }
}
