using System.Security.Claims;

namespace Taht.Application
{
    public interface ICurrentPrincipalAccessor
    {
        ClaimsPrincipal Principal { get; }
    }
}
