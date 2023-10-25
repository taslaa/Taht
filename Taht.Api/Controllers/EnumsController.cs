using Microsoft.AspNetCore.Mvc;

using Taht.Common.Services;

namespace Taht.Api.Controllers
{
    public class EnumsController : BaseController
    {
        private readonly IEnumsService _enumsService;

        public EnumsController(IEnumsService enumsService, ILogger<EnumsController> logger) : base(logger)
        {
            _enumsService = enumsService;
        }

        [HttpGet("roles")]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 3600)]
        public async Task<IActionResult> GetRoles() => Ok(await _enumsService.GetRolesAsync());
    }
}