using System.Security.Claims;

namespace Taht.Application
{
    public interface ICurrentUser
    {
        int? Id { get; }
        string[] Roles { get; }
        Claim[] GetAllClaims();
        Claim? FindClaim(string claimType);
        Claim[] FindClaims(string claimType);
        bool IsInRole(string roleName);
    }
}
