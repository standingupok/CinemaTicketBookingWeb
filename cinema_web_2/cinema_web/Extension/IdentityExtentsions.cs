using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
namespace cinema_web.Extension
{
    public static class IdentityExtentsions
    {
        public static string GetSpecificClaim(this ClaimsPrincipal claimsPrinipal, string claimType)
        {
            var claim = claimsPrinipal.Claims.FirstOrDefault(x => x.Type == claimType);
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}
