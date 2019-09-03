using System.Collections.Generic;
using System.Security.Claims;

namespace NB.ServiceLayer.IServices
{
   public interface IAntiForgeryCookieService
    {
        void RegenerateAntiForgeryCookies(IEnumerable<Claim> claims);
        void DeleteAntiForgeryCookies();
    }
}
