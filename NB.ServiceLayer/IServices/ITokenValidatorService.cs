
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace NB.ServiceLayer.IServices
{
   public interface ITokenValidatorService
    {
        Task ValidateAsync(TokenValidatedContext context);
    }
}
