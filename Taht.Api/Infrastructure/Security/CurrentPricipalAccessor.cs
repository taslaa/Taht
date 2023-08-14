﻿using Taht.Application;
using System.Security.Claims;

namespace Taht.Api
{
    public class CurrentPricipalAccessor : ICurrentPrincipalAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentPricipalAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public ClaimsPrincipal Principal => _httpContextAccessor.HttpContext?.User;
    }
}
