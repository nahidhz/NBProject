using System.Threading.Tasks;
using NB.DomainClasses;
using NB.Services;

namespace NB.ServiceLayer.IServices
{
   public interface ITokenFactoryService
    {
        Task<JwtTokensData> CreateJwtTokensAsync(User user);
        string GetRefreshTokenSerial(string refreshTokenValue);
    }
}
