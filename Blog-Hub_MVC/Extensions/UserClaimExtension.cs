using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog_Hub_MVC.Extensions
{
    public static class UserClaimExtension
    {

        public static string GetId(this ClaimsPrincipal principal)
        {
            return principal.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public static bool IsThisUserLoggedOne(this ClaimsPrincipal principal, string id)
        {
            return principal.GetId().Equals(id);
        }

    }
}
