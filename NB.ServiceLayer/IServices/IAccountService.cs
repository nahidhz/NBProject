using NB.DomainClasses;
using NB.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NB.ServiceLayer.IServices
{
  public interface IAccountService
    {
        Task<JwtTokensData> CreateJwtTokens(User user);
    }
}
